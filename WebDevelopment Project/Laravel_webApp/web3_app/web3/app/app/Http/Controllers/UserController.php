<?php

namespace App\Http\Controllers;
use App\interests as Interest;
use App\User as User;
// use Illuminate\Support\Facades\Request;
use Illuminate\Http\Response;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Storage;
use Illuminate\Support\Facades\Input;
use Illuminate\Support\Facades\File;
use App\Http\Controllers\Controller;
use Illuminate\Support\Facades\DB;
use Illuminate\Support\Facades\Auth;
use Illuminate\View\Middleware\ShareErrorsFromSession;
use Image;
use Excel;
use PhpParser\Node\Expr\Array_;

class UserController extends Controller
{

    public function api($id)
    {
        $interest = Interest::find($id);
        return $interest;
    }
    public function full()
    {
        $interest = Interest::all();
        return $interest;
        
    }
    public  function excel()
    {
       $ex = User::select('id','name','email','created_at')->get();
        Excel::create('User',function($excel)use ($ex){
            $excel->sheet('Sheet 1', function($sheet) use($ex) {
                $sheet->fromArray($ex);
            });
        })->download('xlsx');
    }
    // to get image of the user in the table
    public function img($id)
    {
        $interest=Interest::find($id);

       $img = Storage::get('Images/'.$interest->id .'/' .$interest->image);
        return Response($img,200);
    }
    public function index()
    {
        $interests=Interest::all();
        $admin2 = 0;
        if(Auth::check()) {
            $admin = User::select('admin')->where('id', '=', Auth::user()->id)->first();
            $admin1 = $admin->admin;

            if ($admin1 == 1)
            {
                $admin2 = 1;
            }
        }
        return view('interests.index',compact('interests'))->with('admin2',$admin2);
    }
    /**
     * Show the form for creating a new resource.
     *
     * @return Response
     */
    //
    public function create()
    {
        return view('interests.create');
    }
    /**
     * Store a newly created resource in storage.
     *
     * @return Response
     */
    public function store(Request $request)
    {
        $this->validate($request, [
            'interest' => 'required|max:150',
            'image' => 'required|mimes:jpg,jpeg,png|max:4000',
        ]);
        $user = Auth::user()->name;
        $interest = $request->interest;       
        \Session::flash('flash_message',' Interest is added successfully');
        $file = Input::file('image');
        $name = $file->getClientOriginalName();

     DB::table('interests')->insert([
            ['user' => $user, 'interest' => $interest, 'image' => $name]
        ]);
        $id =  DB::table('interests')->where('interest', $interest)->first();
        $id1 = $id->id;
        $image = Input::file('image');
        $path = storage_path('app/Images/'.$id1);
        File::makeDirectory($path,0755,true,true);
        $img = Image::make($image->getRealPath())->resize(300,300);
        $water = Storage::disk('local')->get('Lannister_Watermark.png');
        $watermark = Image::make($water)->resize(150,150);
        $img->insert($watermark,'center');
        $img->save($path . '/' . $name);
        return redirect('interests');
    }


    /**
     * Display the specified resource.
     *
     * @param  int  $id
     * @return Response
     */
    public function show($id)
    {
        $interest=Interest::find($id);
        return view('interests.show',compact('interest'));
    }

    /**
     * Show the form for editing the specified resource.
     *
     * @param  int  $id
     * @return Response
     */
    public function edit($id)
    {
        $interest=Interest::find($id);
        return view('interests.edit',compact('interest'));
    }
    /**
     * Update the specified resource in storage.
     *
     * @param  int  $id
     * @return Response
     */
    public function update($id, Request $request)
    {
        $this->validate($request, [
            'interest' => 'max:150',
        ]);
        if($request->hasFile('image'))
        {
            $this->validate($request, [
                'image' => 'mimes:jpg,jpeg,png|max:4000',
            ]);
            $file = Input::file('image');
            $name = $file->getClientOriginalName();
            $image = Input::file('image');
            $path = storage_path('app/Images/'.$id);
            File::makeDirectory($path,0755,true,true);
            $img = Image::make($image->getRealPath())->resize(300,300);
            $water = Storage::disk('local')->get('Lannister_Watermark.png');
            $watermark = Image::make($water)->resize(25,25);
            $img->insert($watermark,'center');
            $img->save($path . '/' . $name);
            DB::table('interests')
                ->where('id',$id)
                ->update(array('image' => $name));
        }
        DB::table('interests')
            ->where('id',$id)
            ->update(array('user' => Auth::user()->name, 'interest' => $request->interest));
        return redirect('interests');
    }
    /**
     * Remove the specified resource from storage.
     *
     * @param  int  $id
     * @return Response
     */
    public function destroy($id)
    {
        Interest::find($id)->delete();
        return redirect('interests');
    }
}

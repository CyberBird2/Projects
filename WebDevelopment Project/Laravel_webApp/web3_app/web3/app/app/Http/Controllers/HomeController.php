<?php

namespace App\Http\Controllers;
use Illuminate\Support\Facades\Auth;
use Illuminate\Support\Facades\DB;
use Illuminate\Http\Request;
use Illuminate\Database\Eloquent\Model;
use Illuminate\Support\Facades\Input;
use Illuminate\Support\Facades\File;
use Intervention\Image\Facades\Image;
use App\User as User;
use Illuminate\Support\Facades\Storage;

class HomeController extends Controller
{

    /**
     * Create a new controller instance.
     *
     * @return void
     */
    public function __construct()
    {
        $this->middleware('auth');
    }

    /**
     * Show the application dashboard.
     *
     * @return \Illuminate\Http\Response
     */
    public function img($id)
    {
        $user = User::find($id);
        $img = Storage::get('Images/'.$user->id .'/'.$user->Avatar);
        return Response($img,200);
    }

    public function index()
    {
        $names = User::all()->where('name',Auth::user()->name);
        $users= User::all();
        $admin = User::select('admin')->where('id','=',Auth::user()->id)->first();
        $admin1 = $admin->admin;
        $admin2 = 0;
        if($admin1 == 1){ $admin2 = 1;}
        else{$admin2 = 0;}
        return view('home', array('names' => $names))->with('admin2',$admin2)->with(array('users'=>$users));
    }
    public function mkAdmin($id)
    {
        User::where('id',$id)
            ->update(array('admin' => 1));
        return redirect('home');
    }

    public  function noAdmin($id)
    {
        User::where('id',$id)
            ->update(array('admin' => 0));
        return redirect('home');
    }

    public  function chngPic ($id)
    {
        if(Input::hasFile('image'))
        {
            $file = Input::file('image');
            $name = $file->getClientOriginalName();
            $image = Input::file('image');
            $path = storage_path('app/Images/'.$id);
            File::makeDirectory($path,0755,true,true);
            $img = Image::make($image->getRealPath())->resize(150,150);
            $img->save($path . '/' . $name);
            DB::table('users')
                ->where('id',$id)
                ->update(array('Avatar' => $name));
        }
        return redirect('home');
    }


}

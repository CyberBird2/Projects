<?php

namespace App\Http\Controllers\Auth;

use App\User;
use Validator;
use App\Http\Controllers\Controller;
use Illuminate\Foundation\Auth\RegistersUsers;
use Illuminate\Support\Facades\File;
use Illuminate\Support\Facades\Storage;
use DB;
use Image;

class RegisterController extends Controller
{
    /*
    |--------------------------------------------------------------------------
    | Register Controller
    |--------------------------------------------------------------------------
    |
    | This controller handles the registration of new users as well as their
    | validation and creation. By default this controller uses a trait to
    | provide this functionality without requiring any additional code.
    |
    */

    use RegistersUsers;

    /**
     * Where to redirect users after login / registration.
     *
     * @var string
     */
    protected $redirectTo = '/home';

    /**
     * Create a new controller instance.
     *
     * @return void
     */
    public function __construct()
    {
        $this->middleware('guest');
    }

    /**
     * Get a validator for an incoming registration request.
     *
     * @param  array  $data
     * @return \Illuminate\Contracts\Validation\Validator
     */
    protected function validator(array $data)
    {
        return Validator::make($data, [
            'name' => 'required|max:255',
            'email' => 'required|email|max:255|unique:users',
            'password' => 'required|min:6|confirmed',
        ]);
    }

    /**
     * Create a new user instance after a valid registration.
     *
     * @param  array  $data
     * @return User
     */
    protected function create(array $data)
    {
        $id1 = DB::table('INFORMATION_SCHEMA.TABLES')
            ->select(DB::raw('AUTO_INCREMENT'))
            ->where([
                ['TABLE_SCHEMA', '=', 'laraveldb'],
                ['TABLE_NAME', '=', 'users']
            ])->first();

        $id = $id1->AUTO_INCREMENT;
        $path = storage_path('app/Images/'.$id);
        File::makeDirectory($path,0755,true,true);
        $d = Storage::disk('local')->get('def.jpg');
        $i = Image::make($d)->resize(200, 200)->fit(200, 200);
        $i->save($path.'/' . 'def.jpg');
        return User::create([
            'name' => $data['name'],
            'email' => $data['email'],

            'password' => bcrypt($data['password']),
        ]);
    }
}

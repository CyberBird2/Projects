<?php

namespace App\Http\Controllers\ApiControllers;

use App\Http\Controllers\Controller;
use Illuminate\Http\Request;
use App\Http\Resources\User as UserResource;
use Illuminate\Support\Str;
use App\User;
use App\Interest;
use Auth;


class ApiUserController extends Controller
{
    public function index()
    {
        return UserResource::collection(User::all());
    } 
    public function show(User $user)
    {
        return new UserResource($user);
    }
    public function update(User $user)
    {
        $user->name = request('name');
        $user->email = request('email');

        $user->save();

        return new UserResource($user);
    }
    public function destroy(User $user)
    {
        $user->delete();
        return response()->json(null,204);
    }
    public function store()
    {
        $user = new User();

        $user->name = request('name');
        $user->email = request('email');
        $user->password = request('password');
        $user->api_token=Str::random(60);

        $user->save();

        return new UserResource($user);


    }
    public function generateToken(User $user)
    {
        $user->api_token = Str::random(60);
        $user->save();

        return $user->api_token;
    }
}

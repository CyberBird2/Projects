<?php

namespace App\Http\Controllers\ApiControllers;

use App\Http\Controllers\Controller;
use Illuminate\Http\Request;
use App\Http\Resources\Interest as InterestResource;
use App\User;
use App\Interest;
use Auth;
class ApiInterestController extends Controller
{
    public function index()
    {
        return InterestResource::collection(Interest::all());
    }
    public function show(Interest $interest)
    {
        return new InterestResource($interest);
    }
    public function destroy(Interest $interest)
    {
        $interest->delete();

        return response()->json(null, 204);
    }
    public function update(Interest $interest)
    {
        $interest->interest = request('interest');
             
        $interest->save();
        return new InterestResource($interest);

        
    }
    public function store()
    {   
        $interest = new Interest();
        $user = new User();
        $id=Auth::user()->id;
        $interest->interest = request('interest');       
        $interest->user=request('user');
        
       
        $interest->save();

        return new InterestResource($interest);
    }

}

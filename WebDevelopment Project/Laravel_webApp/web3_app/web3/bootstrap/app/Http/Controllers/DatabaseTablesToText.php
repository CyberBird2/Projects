<?php

namespace App\Http\Controllers;

use Illuminate\Support\Facades\DB;
use App\Http\Controllers\Controller;

class DatabaseTablesToText extends Controller
{
    
    public function index()
    {
        $names = array('fadi', 'wondi'); 

        return view('home');
    }
}

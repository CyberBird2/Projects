<?php

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| This file is where you may define all of the routes that are handled
| by your application. Just tell Laravel the URIs it should respond
| to using a Closure or controller method. Build something great!
|

Route::get('/',function(){
    return "Hi world";
}); */

 Route::get('/', function () {
    return view('welcome');
});
Route::get('about', function(){
    //$info = ['This is info about the page.', 'Yay, it works'];
    return view('about');
});

Route::get('welcome',function(){
    return view('welcome');
});



Auth::routes();
Route::get('/home', 'HomeController@index');
Route::resource('interests','UserController');
Route::get('app/Images/{id}','UserController@img')->name('images');
Route::get('/excel','UserController@excel')->name('excel');
Route::get('api/{id}','UserController@api')->name('api');
Route::get('allapi','UserController@full')->name('full');
Route::get('app/{id}','HomeController@img')->name('profile');
Route::get('mkAdmin/{id}', 'HomeController@mkAdmin')->name('makeAdmin')->middleware('auth');
Route::get('noAdmin/{id}','HomeController@noAdmin')->name('NoAdmin')->middleware('auth');
Route::post('change/{id}','HomeController@chngPic')->name('changeProf');


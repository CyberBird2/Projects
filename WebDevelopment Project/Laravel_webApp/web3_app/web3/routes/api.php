<?php

use Illuminate\Http\Request;

/*
|--------------------------------------------------------------------------
| API Routes
|--------------------------------------------------------------------------
|
| Here is where you can register API routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| is assigned the "api" middleware group. Enjoy building your API!
|
*/

// Route::get('/user', function (Request $request) {
//     return $request->user();
// })->middleware('auth:api');

Route::group(['middleware' => 'auth:api'], function() {
    //User routes
    Route::get('user', 'ApiControllers\ApiUserController@index')->name('user.index');
    Route::delete('user/{user}', 'ApiControllers\ApiUserController@destroy')->name('user.destroy');
    Route::get('user/{user}', 'ApiControllers\ApiUserController@show')->name('user.show');
    Route::put('user/{user}', 'ApiControllers\ApiUserController@update')->name('user.update');
    Route::post('interest', 'ApiControllers\ApiInterestController@store')->name('interest.store');
    Route::put('interest/{interest}', 'ApiControllers\ApiInterestController@update')->name('interest.update'); 
});
Route::post('user', 'ApiControllers\ApiUserController@store')->name('user.store');
Route::get('interest', 'ApiControllers\ApiInterestController@index')->name('interest.index');
Route::get('interest/{interest}', 'ApiControllers\ApiInterestController@show')->name('interest.show');
Route::delete('interest/{interest}', 'ApiControllers\ApiInterestController@destroy')->name('interest.destroy');




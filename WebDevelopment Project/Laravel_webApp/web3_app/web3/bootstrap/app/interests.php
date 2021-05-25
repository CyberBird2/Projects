<?php

namespace App;


use Illuminate\Notifications\Notifiable;
use Illuminate\Foundation\Auth\User as Authenticatable;
use Illuminate\Database\Eloquent\Model;

class interests extends Model
{

        protected $primaryKey = 'id';
        protected $fillable=[
            'user',
            'interest',
            'image'
           

        ];


}

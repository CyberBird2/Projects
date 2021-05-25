<?php

use Illuminate\Support\Facades\Schema;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Database\Migrations\Migration;

class CreateInterestsTable extends Migration
{
    /**a
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('interests',function(Blueprint $table){
            $table ->increments('id');
            $table ->string('user');
            $table ->string('interest');
            $table ->string('image');
            $table ->string('type');      
            $table ->timestamps();
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::drop('interests');
    }
}

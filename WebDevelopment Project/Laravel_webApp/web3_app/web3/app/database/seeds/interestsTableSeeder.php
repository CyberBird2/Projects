<?php
use Illuminate\Database\Seeder;
use Illuminate\Database\Eloquent\Model;
class interestsTableSeed extends Seeder
{

    public function run()
    {
        DB::table('interests')->delete();

        $interests = array(
            array(
                'id' => '1000',
                'user' => 'Delal',
                'interest' => 'become rich',
                'image' => 'walter-white-money.jpg',
                
            ),
            array (
                'id' => '1001',
                'user' => 'Alex',
                'interest' => 'Kick boxing',
                'image' => 'MPW-12700.jpg',
                
            ),
            array (
                'id' => '1002',
                'user' => 'John',
                'interest' => 'Have a nice car',
                'image' => 'FMHkeX.jpg',
                
            ),
            array (
                'id' => '1003',
                'user' => 'Marco',
                'interest' => 'Have tons of gold',
                'image' => 'large_gold_bars.jpg',
               
            )
        );

        DB::table('interests')->insert($interests);
    }
}
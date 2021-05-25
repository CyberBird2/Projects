<?php

use Illuminate\Database\Seeder;

class UserTableSeed extends Seeder
{
    /**
     * Run the database seeds.
     *
     * @return void
     */
    public function run()
    {
        DB::table('users')->delete();
        $users = array(
            array(

                'name' => 'Delal',
                'password' => Hash::make('123123'),
                'email' => 'delal@gmail.com',
                'Avatar' => 'custom-avatar-admin.jpg',
                'admin' => '1'
            ),
            array(

                'name' => 'John',
                'password' => Hash::make('123123'),
                'email' => 'John@gmail.com',
                'Avatar' => 'def.jpg',
                'admin' => '0'

            ),
            array(

                'name' => 'Marco',
                'password' => Hash::make('123123'),
                'email' => 'Marco@gmail.com',
                'Avatar' => 'def.jpg',
                'admin' => '0'
            )
        );
        DB::table('users')->insert($users);
    }
}

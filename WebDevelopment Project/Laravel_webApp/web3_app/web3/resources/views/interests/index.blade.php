<style>
    html, body {
        background-image: url('../images/wooden.jpg');
        background-repeat: no-repeat;
        background-size: 100% 100%;
        overflow-y: hidden;
        color: #636b6f;
        font-weight: 100;
        height: 100vh;
        margin: 0;


    }
   
</style>


@extends('layouts/personal')

@section('content')
    <h1 style="font-family: 'Comic Sans MS'; color:white; margin-top:30px" >All Individual Interests</h1>
    @if(Auth::check())
    <a href="{{url('/interests/create')}}" class="btn btn-primary" style="font-family: 'Comic Sans MS'; font-size:18px; color:whitesmoke; margin-top:10px;">Add Interests</a>
    @endif
    <a href="{{url('/welcome')}}" class="btn btn-warning"style="font-family: 'Comic Sans MS';font-size:18px; color:white; margin-top:10px;">Return to home page</a>
    <a href="{{url('/allapi')}}" class="btn btn-success" style="font-family: 'Comic Sans MS'; font-size:18px; color:white; margin-top:10px;">Get All API</a>
    <hr>
    <table class="table table-striped table-bordered table-hover" style="font-family: 'Comic Sans MS'; color:black;background-color:white;">
        <thead>
        <tr class="bg- info"   >
            <th style= " font-size: 18px; background-color:white;" >Interest_id</th>
            <th style= " font-size:18px;background-color:white; text-align: center" > User</th>
            <th style= " font-size:18px;background-color:white; text-align: center">Interest</th>          
            <th style= " font-size:18px; background-color:white;text-align: center">Image</th>
            <th style= " font-size:18px;background-color:white; text-align: center" colspan="4">Actions</th>
        </tr>
        </thead>
        <tbody style= " text-align: center" >
        @foreach ($interests as $interest)
            <tr style="background-color: gray;">
                <td style="color: white; font-size:20px; ">{{ $interest->id }}</td>
                <td style="color: white; font-size:20px; ">{{ $interest->user }}</td>
                <td style="color: white; font-size:20px; ">{{ $interest->interest }}</td>
             
                <td><img src="{{route('images',$interest->id)}}" height="35" width="30"></td>
                <td><a href="{{route('api',$interest->id)}}" class="btn btn-success">Get API</a></td>
               
                <td><a href="{{url('interests',$interest->id)}}" class="btn btn-primary">Details</a></td>

                @if(Auth::check())
                         @if($admin2 == 1)
                <td><a href="{{route('interests.edit',$interest->id)}}" class="btn btn-warning">Update</a></td>
                <td>
                    {!! Form::open(['method' => 'DELETE', 'route'=>['interests.destroy', $interest->id]]) !!}
                    {!! Form::submit('Delete', ['class' => 'btn btn-danger']) !!}
                    {!! Form::close() !!}
                </td>
                        @endif
                @if(Auth::user()->name == $interest->user)
                    <td><a href="{{route('interests.edit',$interest->id)}}" class="btn btn-warning">Update</a></td>
                    <td>
                        {!! Form::open(['method' => 'DELETE', 'route'=>['interests.destroy', $interest->id]]) !!}
                        {!! Form::submit('Delete', ['class' => 'btn btn-danger']) !!}
                        {!! Form::close() !!}
                    </td>
                    @endif
                @endif


            </tr>
        @endforeach

        </tbody>

    </table>
@endsection

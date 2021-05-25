<style>
    html, body {
        background-image: url('../images/wooden.jpg');
        background-repeat: no-repeat;
        background-size: 100% 100%;
        overflow-y: hidden;
        color: white;
        font-weight: 100;
        height: 100vh;
        margin: 0;
        
        

    }
</style>
@extends('layouts.personal')
@section('content')
    <h1 style="font-family: 'Comic Sans MS'; color:white; margin-top:30px" >Add Interests</h1>
    @if (count($errors) > 0)
        <div class="alert alert-danger">
            <ul>
                @foreach($errors->all() as $error)
                    <li>{{$error}}</li>
                @endforeach
            </ul>
        </div>
    @endif
    {!! Form::open(['url' => 'interests', 'files'=> true] ) !!}
    <div class="form-group"style="font-family: 'Comic Sans MS'; color:white; font-size:20px; margin-top:30px">

        {!! Form::label('Interest', 'Interest:') !!}
        {!! Form::text('interest',null,['class'=>'form-control']) !!}
    </div>
    
    <div class="form-group">
        <input type="file" name="image" style="font-family: 'Comic Sans MS'; color:white; font-size:20px; margin-top:30px" >
        
    </div>
    <div class="form-group"  style="font-family: 'Comic Sans MS'; color:white; margin-top:30px font-size:50px;">
        {!! Form::submit('Save', ['class' => 'btn btn-success form-control']) !!}
    </div>

    {!! Form::close() !!}
    <div class="form-group" style="font-family: 'Comic Sans MS'; color:white; margin-top:30px font-size:20px;">
        <div class="col-sm-offset-2 col-sm-10" style="right:205px;">
            <a href="{{ url('interests')}}" class="btn btn-warning">Return</a>
        </div>
    </div>
@stop


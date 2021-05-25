<style>
    html, body {
        background-image: url('../../images/wooden.jpg');
        background-repeat: no-repeat;
        background-size: 100% 100%;
        overflow-y: hidden;
        color: #636b6f;
        font-weight: 100;
        height: 100vh;
        margin: 0;

    }
</style>
@extends('layouts.personal')
@section('content')
     <h1 style="font-family: 'Comic Sans MS'; color:white; margin-top:30px">Update Interest</h1>
    
    @if (count($errors) > 0)
        <div class="alert alert-danger">
            <ul>
                @foreach($errors->all() as $error)
                    <li>{{$error}}</li>
                @endforeach
            </ul>
        </div>
    @endif
    {!! Form::model($interest,['method' => 'PATCH','route'=>['interests.update',$interest->id],'files'=>true]) !!}

    <div class="form-group" style="font-family: 'Comic Sans MS'; font-size:20px; color:white; margin-top:30px">
        {!! Form::label('Interest', 'Interest:') !!}
        {!! Form::text('interest',null,['class'=>'form-control']) !!}
    </div>
   
    <div class="form-group" style="font-family: 'Comic Sans MS'; font-size:20px; color:white; margin-top:30px" >
    <input type="file" name="image">
    </div>
    <div class="form-group" style="font-family: 'Comic Sans MS'; margin-top:30px">
        {!! Form::submit('Update', ['class' => 'btn btn-warning']) !!}
    </div>
    {!! Form::close() !!}
@stop
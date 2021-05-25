<style>
    html, body {
        background-image: url('../images/wooden.jpg');
        background-repeat: no-repeat;
        background-size: 100% 100%;
        

    }
</style>
@extends('layouts/personal')
@section('content')
    <h1 style="font-family: 'Comic Sans MS'; color:white; margin-top:30px">Selected Interest</h1>
    <form class="form-horizontal">
        <div class="form-group">
            <label for="image" class="col-sm-2 control-label" style="font-family: 'Comic Sans MS'; color:white; margin-top:30px">Interest Image</label>
            <div class="col-sm-10">
                <img src="{{route('images',$interest->id)}}" height="180" width="180" style="border-radius:50%" class="img-rounded">
            </div>
        </div>
        <div class="form-group" style="font-family: 'Comic Sans MS'; color:white; margin-top:30px">
            <label for="interest_id" class="col-sm-2 control-label" >Interest ID</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="interest_id" placeholder={{$interest->id}} readonly>
            </div>
        </div>
        <div class="form-group" style="font-family: 'Comic Sans MS'; color:white; margin-top:30px">
            <label for="user" class="col-sm-2 control-label">User Name</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="user" placeholder={{$interest->user}} readonly>
            </div>
        </div>
        <div class="form-group" style="font-family: 'Comic Sans MS'; color:white; margin-top:30px">
            <label for="interest" class="col-sm-2 control-label">Interest</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="interest" placeholder={{$interest->interest}} readonly>
            </div>
        </div>
       

        <div class="form-group">
            <div class="col-sm-offset-2 col-sm-10">
                <a href="{{ url('interests')}}" class="btn btn-warning" style="font-family: 'Comic Sans MS'; color:white; margin-top:10px">Return</a>
            </div>
        </div>
    </form>
@stop
<style>
    html, body {
       
        background-image: url('../images/wooden.jpg'); 
        background-repeat: no-repeat, repeat;
        background-size: 100% 100%;
        padding-bottom: 0%;

    }
    </style>

@extends('layouts.app')

@section('content')
    <link href="https://fonts.googleapis.com/css?family=Baloo+Bhaina" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css?family=Raleway:100,600" rel="stylesheet" type="text/css">
<div class="container">
    <div class="row" style="padding:15%;">
        <div class="col-md-8 col-md-offset-2">
                <div class="panel-heading" style="font-family: 'Comic Sans MS', cursive; font-size:400%;color: rgb(211, 189, 62);padding-left:20%;">Register</div>
                    <form class="form-horizontal" role="form" method="POST" action="{{ url('/register') }}" >
                        {{ csrf_field() }}

                        <div class="form-group{{ $errors->has('name') ? ' has-error' : '' }}">
                            <label for="name" class="col-md-4 control-label" style="color: #fff; font-family:'Comic Sans MS'; font-weight: bold;">Name</label>

                            <div class="col-md-6">
                                <input id="name" type="text" class="form-control" name="name" value="{{ old('name') }}" required autofocus>

                                @if ($errors->has('name'))
                                    <span class="help-block">
                                        <strong>{{ $errors->first('name') }}</strong>
                                    </span>
                                @endif
                            </div>
                        </div>

                        <div class="form-group{{ $errors->has('email') ? ' has-error' : '' }}">
                            <label for="email" class="col-md-4 control-label" style="color: #fff; font-family:'Comic Sans MS'; font-weight: bold;">E-Mail Address</label>

                            <div class="col-md-6">
                                <input id="email" type="email" class="form-control" name="email" value="{{ old('email') }}" required>

                                @if ($errors->has('email'))
                                    <span class="help-block">
                                        <strong>{{ $errors->first('email') }}</strong>
                                    </span>
                                @endif
                            </div>
                        </div>

                        <div class="form-group{{ $errors->has('password') ? ' has-error' : '' }}">
                            <label for="password" class="col-md-4 control-label" style="color: #fff; font-family:'Comic Sans MS'; font-weight: bold;">Password</label>

                            <div class="col-md-6">
                                <input id="password" type="password" class="form-control" name="password" required>

                                @if ($errors->has('password'))
                                    <span class="help-block">
                                        <strong>{{ $errors->first('password') }}</strong>
                                    </span>
                                @endif
                            </div>
                        </div>

                        <div class="form-group{{ $errors->has('password_confirmation') ? ' has-error' : '' }}">
                            <label for="password-confirm" class="col-md-4 control-label" style="color: #fff; font-family:'Comic Sans MS';font-weight: bold;">Confirm Password</label>

                            <div class="col-md-6">
                                <input id="password-confirm" type="password" class="form-control" name="password_confirmation" required>

                                @if ($errors->has('password_confirmation'))
                                    <span class="help-block">
                                        <strong>{{ $errors->first('password_confirmation') }}</strong>
                                    </span>
                                @endif
                            </div>
                        </div>
                            <br>
                        <div class="form-group">
                            <div class="col-md-6 col-md-offset-4">
                                <button type="submit" class="btn btn-warning"style="color: #fff; font-family:'Comic Sans MS';font-weight: bold;">
                                    Register
                                </button>
                            </div>
                        </div>
                    </form>
                

        </div>
    </div>
</div>
@endsection

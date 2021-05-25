
<style>
    html, body {
       
        background-image: url('../images/wooden.jpg'); 
        background-repeat: no-repeat, repeat;
        background-size: 1000% 100%;
        padding-bottom: 0%;

    }
    </style>
@extends('layouts.app')

<!-- Main Content -->
@section('content')
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap.min.css">
<div class="container">
    <div class="row " style="padding-top:20%">
        <div class="col-md-8 col-md-offset-2" style="background-color:transparent">
            <div class="panel panel-default" style="background-color: grey">
                <div class="panel-heading"style="font-family: 'Comic Sans MS', cursive; font-size:250%; color:rgb(211, 189, 62);font-weight: bold;">Reset Password</div>
                <div class="panel-body">
                    @if (session('status'))
                        <div class="alert alert-success">
                            {{ session('status') }}
                        </div>
                    @endif

                    <form class="form-horizontal" role="form" method="POST" action="{{ url('/password/email') }}">
                        {{ csrf_field() }}

                        <div class="form-group{{ $errors->has('email') ? ' has-error' : '' }}">
                            <label for="email"  class="col-md-4 control-label" style="color:white; font-family:'Comic Sans MS'; font-weight: bold;" >E-Mail Address</label>

                            <div class="col-md-6">
                                <input id="email" type="email" class="form-control" name="email" value="{{ old('email') }}" required>

                                @if ($errors->has('email'))
                                    <span class="help-block">
                                        <strong>{{ $errors->first('email') }}</strong>
                                    </span>
                                @endif
                            </div>
                        </div>

                        <div class="form-group">
                            <div class="col-md-6 col-md-offset-4" style="color:white; font-family:'Comic Sans MS'; font-weight: bold;">
                                <button type="submit" class="btn btn-success">
                                    Send Password Reset Link
                                </button>
                            </div>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
</div>
@endsection

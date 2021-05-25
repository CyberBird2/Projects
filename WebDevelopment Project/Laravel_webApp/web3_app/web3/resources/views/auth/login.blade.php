<div style="align-items: center">
@extends('layouts.app')

@section('content')
        <link href="https://fonts.googleapis.com/css?family=Baloo+Bhaina" rel="stylesheet">
        <link href="https://fonts.googleapis.com/css?family=Raleway:100,600" rel="stylesheet" type="text/css">
        
<div class="container" >
    <div class="row" style="padding-top:20%">
        <div class="col-md-8 col-md-offset-2">

                <div class="panel-heading" style="font-family: 'Comic Sans MS', cursive; font-size:400%; color:rgb(211, 189, 62);">Login</div>

                    <form class="form-horizontal" role="form" method="POST" action="{{ url('/login') }}">
                        {{ csrf_field() }}

                        <div class="form-group{{ $errors->has('email') ? ' has-error' : '' }}" style="margin-right: 100px">
                            <label for="email" class="col-md-4 control-label" style="color: #fff; font-family:'Comic Sans MS'; font-weight: bold;">E-Mail Address</label>

                            <div class="col-md-6">
                                <input id="email" type="email" class="form-control" name="email" value="{{ old('email') }}" required autofocus>

                                @if ($errors->has('email'))
                                    <span class="help-block">
                                        <strong>{{ $errors->first('email') }}</strong>
                                    </span>
                                @endif
                            </div>
                        </div>

                        <div class="form-group{{ $errors->has('password') ? ' has-error' : '' }}" style="margin-right: 100px">
                            <label for="password" class="col-md-4 control-label" style="color: #fff; font-family:'Comic Sans MS'; font-weight: bold;" >Password</label>

                            <div class="col-md-6">
                                <input id="password" type="password" class="form-control" name="password" required>

                                @if ($errors->has('password'))
                                    <span class="help-block">
                                        <strong>{{ $errors->first('password') }}</strong>
                                    </span>
                                @endif
                            </div>
                        </div>

                        <div class="form-group">
                            <div class="col-md-6 col-md-offset-4">
                                
                                        <div style="color: skyblue; font-family:'Comic Sans MS';font-weight: bold; margin-left: 50px;">Remember Me &nbsp &nbsp<input  type="checkbox" name="remember" ></div>

                        
                            </div>
                        </div>

                        <div class="form-group">
                            <div class="col-md-8 col-md-offset-4">
                                <button type="submit" class="btn btn-warning" style="margin-right: 270px;color: #fff; font-family:'Comic Sans MS';font-weight: bold;" >
                                    Login
                                </button>
                                <a class="btn btn-link" href="{{ url('/password/reset') }}" style=" margin-right: 270px;color:skyblue; font-family:'Comic Sans MS';font-weight: bold;">
                                    Forgot Your Password?
                                </a>
                            </div>
                          

                    </form>
            </div>
        </div>
    </div>
</div>
</div>
@endsection

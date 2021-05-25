<style>
    html, body {
       
        background-image: url('../images/wooden.jpg'); 
    }
    </style>
@extends('layouts.app')

@section('content')
    <link href="https://fonts.googleapis.com/css?family=Raleway:100,600" rel="stylesheet" type="text/css">
<div class="container">
    <div class="row" style="padding-top:10%">
        <div class="col-md-8 col-md-offset-2">
           
            <div style="color:#fff;">
            @foreach($names as $x)

                    <img src="{{route('profile',$x->id)}}" height="200" width="200" style="border-radius:50%" class="img-rounded">
                    <br>
                    <br>
                    <button class="btn btn-warning" name="hideMe" id="hideMe" style="display: inline;font-family:'Comic Sans MS';font-weight: bold; font-size:20px;" onclick="ShowHide()">Change Profile Picture</button>
                    <form method="post" action="{{route('changeProf',$x->id)}}" enctype="multipart/form-data">
                        <input type="file" style="display: none" name="image" id="image">
                        <br>
                        <input type="hidden" value="{{ csrf_token() }}" name="_token">
                    <input type="submit" style="display: none;" name="showMe" id="showMe" class="btn btn-warning" value="Change Picture">
                    </form>

                <br>
                <strong style="color: #fff; font-family:'Comic Sans MS';font-weight: bold; font-size:20px;"> {{$x->name}} </strong>
            @endforeach
            </div>

                <div class="panel-body" style="color:lightgreen;font-size:20px; font-family:'Comic Sans MS';font-weight: bold;">
                    You are logged in!
                </div>
<br>


            <a href="{{ url('/logout') }}"onclick="event.preventDefault();document.getElementById('logout-form').submit();">
              <button class="btn btn-danger" style="color: #fff; font-family:'Comic Sans MS';font-weight: bold; font-size:20px;" >  Logout
              </button>
            </a>
            <br>
            <br>
                @if($admin2 == 1)
            <a href="{{route('excel')}}"><button class="btn btn-success">Export to excel</button></a>
                <table class="table table-bordered" style="background-color: #fff;">
                    <br>
                    <br>
                    <thead align="center">
                    <tr class="bg-info" style="color: black; text-align: center ; font-family:'Comic Sans MS';font-weight: bold; font-size:17px;" >
                        <th style="text-align: center ;">ID</th>
                        <th style="text-align: center ;">User</th>
                        <th style="text-align: center ;">E-mail</th>
                        <th style="text-align: center ;">Admin</th>
                        <th colspan="4" style="text-align: center ;">Actions</th>
                    </tr>
                    </thead>
                    <tbody align="center">
                    @foreach($users as $u)
                        <tr>
                            <td>{{ $u->id }}</td>
                            <td>{{ $u->name }}</td>
                            <td>{{ $u->email}}</td>
                            <td>{{ $u->admin }}</td>
                            <td><a href="{{route('makeAdmin', $u->id)}}" class="btn btn-success">Make Admin</a></td>
                            <td><a href="{{route('NoAdmin', $u->id)}}" class="btn btn-danger">Remove Admin</a></td>
                        </tr>
                    @endforeach
                    </table>
                @endif
            <br>
            {{--</div>--}}
        </div>
    </div>
</div>
@endsection
<script>
    function ShowHide()
    {
        document.getElementById('hideMe').style.display = 'none';
        document.getElementById('showMe').style.display = 'inline';
        document.getElementById('image').style.display = 'inline';
    }
</script>

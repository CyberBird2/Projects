<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <title>Shared Interests</title>

    <!-- Fonts -->
    <link href="https://fonts.googleapis.com/css?family=Raleway:100,600" rel="stylesheet" type="text/css">
    <link rel="stylesheet" type="text/css" href="//fonts.googleapis.com/css?family=Indie+Flower" />
    <!-- Styles -->
    <link rel="stylesheet" type="text/css" href="/css/style_index">
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

        .full-height {
            height: 100vh;
        }

        .flex-center {
            align-items: baseline;
            display: flex;
            justify-content: center;
            margin: 0;
        }

        .position-ref {
            position: relative;
        }

        .top-right {
            position: fixed;
            right: 10px;
            top: 18px;
            font-family: 'Comic Sans MS';
            color:#ffffff;
            font-size: 30px;
            

        }
        .top-left {
            position: fixed;
            left: 10px;
            top: 18px;
            font-family: 'Comic Sans MS';
            color:#ffffff;
            font-size: 30px;
            font-style:inherit;

        }

        .content {
            text-align: center;
            padding:20%;
            font-family: 'Comic Sans MS';
            color:#fff;
            
        }

        .title {
            font-size: 84px;
            font-family: 'Comic Sans MS';
            color:rgb(211, 189, 62);
            font-style: italic;
        }

        .links > a {
            color: #fff;
            padding: 0 25px;
            font-size: 15px;
            font-weight: 600;
            letter-spacing: .1rem;
            text-decoration: none;
            text-transform: uppercase;
           
            
        }

        a:hover {
                color: #FF9F00;
                text-decoration: none;
                list-style-type: none;
            
                } 
          

        .m-b-md {
            margin-bottom: 30px;
        }
        .inactiveLink {
            pointer-events: none;
            cursor: default;
            text-underline: none;

        }
    </style>
</head>
<body>

<div class="flex-center position-ref full-height">
    @if (Auth::check())
      <div class="top-right links">
            <a href="{{url('/home')}}">{{ Auth::user()->name }}</a>
            <a href="about">About</a>
           <a href="https://git.fhict.nl/I412627/web3-fadi_wondimu_project">GitLab</a> 

        </div>

    @else
        <div class="top-right links">
            <a href="{{ url('/login') }}">Login</a>
            <a href="about">About</a>
            <a href="https://git.fhict.nl/I412627/web3-fadi_wondimu_project">GitLab</a> 
        </div>
@endif

    <div class="content">
        <div class="title m-b-md">
            Shared Intersts
        </div>

        <div class="top-left links">
            <a href={{url('/interests')}}>Create your own interests</a>
            <a href=""> Intersted to</a>
        </div>

    </div>
</div>
</body>
</html>

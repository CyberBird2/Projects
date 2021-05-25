<!DOCTYPE html>
<html lang="en">
    <style>
        html, body {
           
            background-image: url('../images/wooden.jpg'); 
            background-repeat: no-repeat, repeat;
            background-size: 100% 100%;
            padding-bottom: 0%;
        }
        navbar-header:hover {
                color: #FF9F00;
                text-decoration: none;
                list-style-type: none;
            
                } 
          
        
        </style>
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link href="https://fonts.googleapis.com/css?family=Raleway:100,400,600" rel="stylesheet" type="text/css">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap.min.css">
    <link rel="stylesheet" type="text/css" href="//fonts.googleapis.com/css?family=Indie+Flower" />
    <!-- CSRF Token -->
    <meta name="csrf-token" content="{{ csrf_token() }}">

    <title>{{ config('app.name', 'Laravel') }}</title>

    <!-- Styles -->
    <link href="/css/app.css" rel="stylesheet">
    
    <!-- Scripts -->
    <script>
        window.Laravel =<?php echo json_encode([
            'csrfToken' => csrf_token(),
        ]); ?>
    </script>
   
</head>
<body  align="center" >

        <div class="container">
            <div class="navbar-header">

                <!-- Collapsed Hamburger -->


                <!-- Branding Image -->
                <a class="navbar-brand" href="{{ url('/') }}" style="color:#fff;  font-weight:bold;font-family: 'Comic Sans MS'; font-size: 24px; top: 18px; left:20px; margin-top:20px;position:fixed;">
                    {{ config('app.name', 'Laravel') }}
                </a>
            </div>


            <div class="collapse navbar-collapse" id="app-navbar-collapse">
                <!-- Left Side Of Navbar -->

        

       
                <!-- Right Side Of Navbar -->
                    <ul class="nav navbar-nav navbar-right">
                    <!-- Authentication Links -->
                    @if (Auth::guest())
                        <li><a href="{{ url('/login') }}" style="color:#fff; font-family: 'Comic Sans MS'; font-weight:bold; font-size:24px; top: 18px; right:200px; margin-top:20px;position:fixed; ">Login</a></li>
                        <li><a href="{{ url('/register') }}" style="color:#fff; font-family: 'Comic Sans MS'; font-weight: bold; font-size:24px; top: 18px; right:40px; margin-top:20px;position:fixed">Register</a></li>
                    @else
                        <li class="dropdown">
                            <a style="color:#fff;  font-weight:bold;font-family: 'Comic Sans MS'; font-size: 24px; top: 18px; right:20px; margin-top:20px;position:fixed; " class="dropdown-toggle" data-toggle="dropdown" role="" aria-expanded="false">
                                <div style="text-align: center" >
                                <b> {{ Auth::user()->name }} <span class="caret"></span> </b>
                                </div>
                            </a>
                            <br>

                            <ul class="dropdown-menu" role="menu">
                                <li>
                                    <a href="{{ url('/logout') }}"
                                        onclick="event.preventDefault();
                                                 document.getElementById('logout-form').submit();">
                                        Logout
                                    </a>

                                    <form id="logout-form" action="{{ url('/logout') }}" method="POST" style="display: none;">
                                        {{ csrf_field() }}
                                    </form>
                                </li>
                            </ul>
                        </li>
                    @endif
                </ul>
            </div>
        </div>

 @yield('content')

    <!-- Scripts -->
    <script src="/js/app.js"></script>
</body>
</html>

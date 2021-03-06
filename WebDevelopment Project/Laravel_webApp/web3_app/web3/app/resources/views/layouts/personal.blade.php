<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Interest View</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap.min.css">
    <link href="https://fonts.googleapis.com/css?family=Raleway:100,600" rel="stylesheet" type="text/css">
    <style>
        .img-rounded:hover
        {transition: all 1s ease;
         -webkit-filter: blur(5px);}
    </style>

</head>

<body>
<div class="container">
    @if(Session::has('flash_message'))
        <div class="alert alert-success">
            <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>

            {{ Session::get('flash_message') }}
        </div>
        @endif
    @yield('content')
</div>
<script src="//code.jquery.com/jquery.js"></script>
<script src="//maxcdn.bootstrapcdn.com/bootstrap/3.2.0/js/bootstrap.min.js"></script>
</body>
</html>
<?php
session_start();
?>
<!DOCTYPE html>
<html>
    <head>
        <title>Home page </title>
        <Style>
        <?php include('assets/css/random.css'); ?>
        </Style>
            <meta charset="UTF-8" />
            <!--Font awesome icons-->
            <script src="https://kit.fontawesome.com/dcfd520e33.js" crossorigin="anonymous"></script>
            <!--Font familiy-->
            <link href="https://fonts.googleapis.com/css?family=B612&display=swap" rel="stylesheet">
            <!--header-->
            <?php include('includes/header.inc.php'); ?>
            <?php include( 'includes/auth/insert-comment.php');?>
        </head>
  <body>
     <div class="wrapper">
                      <div class="maincontent2">
                  <!--Headliners slider with placeholder images
                    <div class="slider">
                    <a href="X"><img src="images/ouat1400x900.png"  alt="image1"></a>
                  -->
                  <div class="container1">
                    <a href=""><div class="slider"></div></a>
                  </div>
                    <!--<a href="X"><img src="images/image2.png"  alt="image2"></a>
                    <a href="X"><img src="images/image3.png"  alt="image3"></a>
                    <a href="X"><img src="images/image4.png"  alt="image4"></a>
                    <a href="X"><img src="images/image5.png"  alt="image5"></a>-->
                  <!--Highlights with placeholder images-->
                  <div class="highlight1">
                      <a href="X"><img src="images/image1.png"  alt="image1"></a>
                  </div>
                  <div class="highlight2">
                      <a href="X"><img src="images/image2.png"  alt="image2"></a>
                  </div>
                  <!--<div class="container 2">
                    <a href="X"><div class="highlight1"></div></a>
                  </div>-->
                  <!--<div class="container3">
                    <a href="X"><div class="highlight2"></div></a>
                  </div>-->   
                  <?php 
                  echo"<form class='premierss' action='".getMovieRates($conn)."'>
                  
                  </form>";     
                
                        getMovieRates($conn);
                      
                  echo"<form class='premierss' action='".getTvShowRates($conn)."'>
                  
                        </form>";   

                        getTvShowRates($conn);
                     
                  ?>
                  <div class="videos">
                    <div class="top-trailers-title">
                    <h1>Top Trailers</h1>
                    </div>
                   
                    <div class="line"> </div>
                    <iframe width="560" height="315" src="https://www.youtube.com/embed/ELeMaP8EPAA" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
                    <iframe width="560" height="315" src="https://www.youtube.com/embed/xhJ5P7Up3jA" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
                    <iframe width="560" height="315" src="https://www.youtube.com/embed/zPXqwAGmX04" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
                  </div>
                  <!--footer-->
                  <?php include('includes/footer.inc.php'); ?>
          </div>
     </div>
  </body>
</html>
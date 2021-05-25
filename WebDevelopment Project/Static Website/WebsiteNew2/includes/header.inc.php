<!-- header-->
<?php

session_start();S

?>
<head>
<style>
<?php include('assets/css/random.css'); ?>
</style>
<script src="https://kit.fontawesome.com/dcfd520e33.js" crossorigin="anonymous"></script>
</head>
<div class="LOGO">
            <img src="images/LOGO2.png" alt="LOGO" width="200" height="50"></li>
        </div>
              <div class="navbar">                     
                      <a href="index.php">Home</a>
                      <a href="AboutUs.php">About us</a>  
                      <a href ="contactus.php">Contact us</a>                  
                      <div class="dropdown">
                        <button class="dropbtn">Movies
                          <i class="fas fa-caret-down"></i>
                        </button>
                        <div class="dropdown-content">
                          <a href="TopRatedMovies.php">Top movies</a>
                          <a href="ComingSoon.php">Coming Soon</a>
                          <a href="OpeningThisWeek.php">This week</a>     
                        </div>                     
                      </div>
              <div class="dropdownshows">
                                      <button class="dropbtn">Tv shows
                                                      <i class="fas fa-caret-down"></i>
                                      </button>
                        <div class="dropdown-content">
                                      <a href="TopTvShows.php">Top shows</a>
                                      <a href="TvShowsCommingSoon.php">Coming soon</a>
                       </div>                                   
              </div>          
              <div class="Loginsignup">
              <?php
              if (!isset($_SESSION['user_id']))
              {
                echo' <a href="login.php">Log in</a>
                <a href="signup.php">Sign up</a>';
              }
              else if (isset($_SESSION['user_id'])) 
              {
                      echo' <a href="logout.php">Log out</a>';
              }
              ?>

              </div>                      
              </div>
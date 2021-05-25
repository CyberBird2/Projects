<?php 
date_default_timezone_set('Europe/Amsterdam');
include 'includes/auth/insert-comment.php';
session_start();
 ?>

<!DOCTYPE html>
<html>
    <head>
        <title>Comments of tv shows </title>
        <Style>
        <?php include('assets/css/random.css'); ?>
        </Style>
            <meta charset="UTF-8" />
            <!--Font awesome icons-->
            <script src="https://kit.fontawesome.com/dcfd520e33.js" crossorigin="anonymous"></script>
            <!--Font familiy-->
            <link href="https://fonts.googleapis.com/css?family=B612&display=swap" rel="stylesheet">
            <!--Letter-counting-js-->
            <script>
            <?php include('assets/js/Letter-counting.js'); ?>
            </script>
            <!--header-->
            <?php include('includes/header.inc.php'); ?>
        </head>
    <body>                       
        <div class="wrapper">
        <div class="maincontent01">
          <?php
           if(isset($_SESSION['user_id']))
           {
             echo"<form class='Comment-main'method='POST' action='".setCommentsTvShow($conn)."'>
             <div class='comment-form-content'>
             <input type='hidden' name='userid' value='".$_SESSION['user_id']."'>
             <label class='comment-movie-name-label'>Tv Show:</label>
             <input type='text' name='tvshow' class='comment-which-movie' placeholder='Which tv show'>
             <input type='hidden' name='date' value='".date('Y-m-d H:i:s')."'>
             <div class='rate-label'>
             Your Rate:
             </div>
             <select name='rate'class='movie-rating'>
               <option>1</option>
               <option>2</option>
               <option>3</option>
               <option>4</option>
               <option>5</option>     
               </select>
           <div class='label-comment'>
               <label class ='comment-movie-comment-label'>Your comment: </label>
           </div>
             <textarea class='comment-text' name='message' cols='100'rows='10'></textarea>
             <button class='btn-comment-submit' type='comment-submit' name='comment-submit'>Comment</button>
             </div>
             </form> ";   
           }
           else
           {
            
             echo "<p class='comment-info'> You need to be logged in to make a comment</p>";
             
           }           
          getCommentsTvShow($conn);
          ?>
          </div>  
          </div>    


        </div>
              
</body>
</html>
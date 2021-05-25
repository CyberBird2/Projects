<?php 
require 'includes/auth/dbconnect.php';
function setComments($conn)
{
   if(isset($_POST['comment-submit']))
   {
    $uid=$_POST['userid'];
    $date=$_POST['date'];
    $message= $_POST['message'];
    $movie=$_POST['movie'];
    $post_rate=$_POST['rate'];
    
    
    $sql = "INSERT INTO commentsmovies (userid,WhichMovie,DateZone,comment) VALUES ('$uid','$movie','$date','$message')";
    $result = $conn->query($sql);

    $sqlrateMovie="INSERT INTO ratemovie (movieName,rateMovie) VALUES ('$movie','$post_rate')";
    $resul2=$conn->query($sqlrateMovie);
   }
}
function getComments($conn)
{
    $sqlget=$conn->query("SELECT * FROM commentsmovies");
    
    while( $row = $sqlget->fetch())
    {
        $id=$row['userid'];
        $sqlget2=$conn->query("SELECT * FROM users WHERE userid='$id'");
        if($row2 = $sqlget2->fetch())
        {
            echo "<div class='user-comments-box'>";
            echo $row2['username']."<br>";
            echo $row['WhichMovie']."<br>";
            echo $row['DateZone']."<br>";          
            echo nl2br($row['comment']);
            echo "</div>";
        }
       
    }
    

}
function getMovieRates($conn)
{
    $sqlgetrate=$conn->query("SELECT * FROM ratemovie");
    $pre_rating=$current_Rating+$post_rate;
    $current_Rating=$conn->query("UPDATE ratemovie SET rateMovie ='$pre_rating' Where movieName='$movie'");
    while($row=$sqlgetrate->fetch())
    {
        echo "<div class = 'premiers'>";
            echo $row['movieName']."=% ";
            echo $current_Rating = $row['rateMovie'];
         echo "</div>";
    
    }
    // $sql="SELECT * FROM ratemovie";
    // $result=$conn->query($sql);
    // $pre_rating=$current_Rating+$post_rate;
    // $current_Rating=("UPDATE ratemovie SET rateMovie ='$pre_rating' Where movieName='$movie'");
    // while($row=$result->fetch_assoc())
    // {
    //     echo "<div class = 'premiers'>";
    //         echo $row['movieName']."=% ";
    //         echo $current_Rating = $row['rateMovie'];
    //      echo "</div>";
    
    // }
  
    
}
function getTvShowRates($conn)
{
    $sqlgetrate=$conn->query("SELECT * FROM ratetvshow");
    $pre_rating=$current_Rating+$post_rate;
    $current_Rating=$conn->query("UPDATE rateTvShow SET rateTvShow ='$pre_rating' Where tvshowName='$tvshow'");
    while($row=$sqlgetrate->fetch())
    {
        echo "<div class = 'premiers'>";
            echo $row['tvshowName']."=% ";
            echo $current_Rating = $row['rateTvShow'];
         echo "</div>";
    
    }
    // $sql="SELECT * FROM ratemovie";
    // $result=$conn->query($sql);
    // $pre_rating=$current_Rating+$post_rate;
    // $current_Rating=("UPDATE ratemovie SET rateMovie ='$pre_rating' Where movieName='$movie'");
    // while($row=$result->fetch_assoc())
    // {
    //     echo "<div class = 'premiers'>";
    //         echo $row['movieName']."=% ";
    //         echo $current_Rating = $row['rateMovie'];
    //      echo "</div>";
    
    // }
  
    
}

function setCommentsTvShow($conn)
{
   if(isset($_POST['comment-submit']))
   {
    $uid=$_POST['userid'];
    $date=$_POST['date'];
    $message= $_POST['message'];
    $tvshow=$_POST['tvshow'];
    $post_rate=$_POST['rate'];
    
    $sql = "INSERT INTO commentstvshows (userid,WhichTvShow,date,comment) VALUES ('$uid','$tvshow','$date','$message')";
    $result = $conn->query($sql);
    
    $sqlrateTvShow="INSERT INTO ratetvshow (tvshowName,rateTvShow) VALUES ('$tvshow','$post_rate')";
    $resul2=$conn->query($sqlrateTvShow);
   }
}
function getCommentsTvShow($conn)
{
    
    $sqlget=$conn->query("SELECT * FROM commentstvshows");
    
    while( $row = $sqlget->fetch())
    {
        $id=$row['userid'];
        $sqlget2=$conn->query("SELECT * FROM users WHERE userid='$id'");
        if($row2 = $sqlget2->fetch())
        {
            echo "<div class='user-comments-box'>";
            echo $row2['username']."<br>";
            echo $row['WhichTvShow']."<br>";
            echo $row['date']."<br>";          
            echo nl2br($row['comment']);
            echo "</div>";
        }
       
    }
    

}
function getLogin($conn)
{
    if(issset($_POST['login_user']))
    {
        $uid =$_POST['username'];
        $pwd =$_POST['password_1'];
    
        $sql="SELECT * FROM user WHERE username='$uid' AND password='$pwd'";
        $result = $conn->query($sql);
        if(mysqli_num_rows($result)>0)
        {
            if($row = $result->fetch_assoc())
            {
                $_SESSION['userid'] =$row['userid'];
                header("Location: index.php?Loginsuceess");
                exit();
            }
        }
        else
        {
            header("Location: index.php?Loginfailed");
            exit();
        }
    }
  
   
}
function userLogout()
{
    if(issset($_POST['logoutSubmit']))
    {
        session_start();
        session_destroy();
        header("Location: index.php");
    }
}
?>
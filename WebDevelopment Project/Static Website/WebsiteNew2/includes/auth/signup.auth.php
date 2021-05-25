<?php

require 'includes/auth/dbconnect.php';
function setusers($conn)
{
    if(isset($_POST['signsubmit']))
    {
       $name=$_POST['signname'];
       $email=$_POST['signmail'];
       $password=$_POST['signpwd'];
       $password = password_hash($password, PASSWORD_DEFAULT);
       

       $sql="INSERT INTO users (username,email,password) VALUES ('$name','$email','$password')";
       $result =$conn->prepare($sql);  
       $result->bindParam('username',$name);
       $result->bindParam('email',$email);
       $result->bindParam('password',$password);
 
         if($result->execute())
         {
             echo "<p class='signup-info'>Your account has been created</p>";
         }
         else
         {
             echo "Something went wrong";
         }
    }               
}

?>



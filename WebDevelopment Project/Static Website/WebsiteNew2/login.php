

<?php
session_start();
require 'includes/auth/dbconnect.php';

    if(!empty($_POST['mailuid']) && !empty($_POST['loginpwd']))
    {
      $email=$_POST['mailuid'];
      $record = $conn->prepare("SELECT * FROM users WHERE email = '$email'");
      $record->bindParam('email',$_POST['mailuid']);
      $record->execute();
      $result=$record->fetch(PDO::FETCH_ASSOC);

      $message="";
      
      if(count($result)>0 && password_verify($_POST['loginpwd'], $result['password']))
      {
        $_SESSION['user_id']=$result['userid'];
        header("Location: index.php");
      }
      else
      {
        $message ="Sorry something went wrong";
      }
    }
?>
<!DOCTYPE html>
<html>
    <head>
        <title>Login </title>
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
        </head>
     <body>
          <form class="Login-form"  method="post" action="login.php">
          <h1 class="Login-title">Login</h1>
          <input type="text" name="mailuid" placeholder="Enter your email">
          <input type="password" name="loginpwd" placeholder="password">        
          <button type="submit" name="loginsubmit" placeholder="" value="Login">Login</button>
          </form>
          <?php if(!empty($message)): ?>
                      <p class="login-info"><?= $message ?></p>
                      <?php endif; ?>
          <a class="Dont-have-account"href="signup.php">Dont you have a account ? </a>
        <!--footer-->
        <?php include('includes/footer.inc.php'); ?>
    </body>
</html>

<!-- <script type="text/javascript">
    // GETTING ALL INPUT TEXT OBJECTS
    var username = document.forms["vform"]["username"];
    var password = document.forms["vform"]["password"];

    // GETTING ALL ERROR DISPLAY OBJECTS
    var name_error = document.getElementById("name_error");
    var password_error = document.getElementById("password_error");

    // SETTING ALL EVENT LISTENERS
    username.addEventListener("blur", nameVerify, true);
    password.addEventListener("blur", passwordVerify, true);

    //VALIDATION FUNCTION
    function Validate(){
      //USERNAME VALIDATION
      if(username.value == ""){
        username.style.border = "1px solid red";
        name_error.textContent = "Username is required";
        name_error.style.color = "white";
        username.focus();
        return false;
      }
      //PASSWORD VALIDATION
      if(password.value == ""){
        password.style.border = "1px solid red";
        password_error.textContent = "Password is required";
        password_error.style.color = "white";
        password.focus();
        return false;
      }
    }

    //EVENT HANDLER FUNCTIONS
    function nameVerify(){
      if(username.value != ""){
        username.style.border = "2px solid white";
        name_error.innerHTML = "";
        return true;
      }
    }
    function passwordVerify(){
      if(password.value != ""){
        password.style.border = "2px solid white";
        password_error.innerHTML = "";
        return true;
      }
    }
</script> -->

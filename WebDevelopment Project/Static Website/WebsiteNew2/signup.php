<?php
include ('includes/auth/signup.auth.php');
?>
<!DOCTYPE html>
<html>
    <head>
        <title>Signup page </title>
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
        <div class="wrapper-main-sign-up">    
          <section class="section-default">
          <?php
          echo"<h1 class='title-signup'>Signup</h1>
           <form class='form-signup'method='post' action='".setusers($conn)."'>
            <input type='text' name='signname' placeholder='Username'>
            <input type='text' name='signmail' placeholder='E-mail'>
            <input type='password' name='signpwd' placeholder='password'>
            <button type='submit' name='signsubmit' placeholder=''>Signup</button>
          </form>";
          ?>
          </section>  
        </div>
      <!--Footer-->
      <?php include('includes/footer.inc.php'); ?>
    </body>
</html>
<!--adding javascript-->
<!--<script type="text/javascript">
    // GETTING ALL INPUT TEXT OBJECTS
    var username = document.forms["vform"]["username"];
    var email = document.forms["vform"]["email"];
    var password = document.forms["vform"]["password"];
    var password_confirmation = document.forms["vform"]["password_confirmation"];

    // GETTING ALL ERROR DISPLAY OBJECTS
    var name_error = document.getElementById("name_error");
    var email_error = document.getElementById("email_error");
    var password_error = document.getElementById("password_error");

    // SETTING ALL EVENT LISTENERS
    username.addEventListener("blur", nameVerify, true);
    email.addEventListener("blur", emailVerify, true);
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
      //EMAIL VALIDATION
      if(email.value == ""){
        email.style.border = "1px solid red";
        email_error.textContent = "Email is required";
        email_error.style.color = "white";
        email.focus();
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

      //CHECK IF THE PASSWORDS MATCH
      if(password.value != password_confirmation.value){
        password.style.border = "1px solid red";
        password_confirmation.style.border = "1px solid red";
        password_error.innerHTML = "The two passwords do not match";
        password_error.style.color = "white";
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
    function emailVerify(){
      if(email.value != ""){
        email.style.border = "2px solid white";
        email_error.innerHTML = "";
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
</script>-->
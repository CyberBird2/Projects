<!DOCTYPE html>
<html>
<head>
<style>
<?php include('assets/css/random.css'); ?>
</style>
      <meta charset="UTF-8" />
      <!--Font awesome icons-->
      <script src="https://kit.fontawesome.com/dcfd520e33.js" crossorigin="anonymous"></script>
      <!--Font family-->
      <link href="https://fonts.googleapis.com/css?family=B612&display=swap" rel="stylesheet">
      <script>
      <?php include('assets/js/contactus.js'); ?>
      <?php include ('assets/js/Letter-counting.js');?>
      </script>
      <!--Header-->
     <?php include('includes/header.inc.php'); ?>

</head>
<body>
    <div class="wrapper">
    <div class="maincontent-contact">
    <div class="container-contact-form">
        <form class="contact" id="contact-us-form" >
            <h2 class="Contact-us-form-name">Contact us</h2>
            <div class="form-control">
                <input class="contactname"id="contact-name" placeholder="Your name" type="text">
                <div class="contact-name-error"></div>
            </div>
            <div class="form-control">
                <input id="contact-email" placeholder="Your email" type="email">
                <div class="contact-email error"></div>
            </div>         
            <div class="form-control">
                <textarea class="Message-contact"id="contact-message"  onkeyup="countdown(this)"cols="50" rows="10" ></textarea>
                <p id='Countnumber'></p>
                <div class="contact-message-error"></div>
            </div>
            <div class="form-control">
                <input id="contact-submit-btn" type="submit" value="Submit"onclick="contactusformvalidation()"> <span class="status-contact"id="contact-status"></span>
            </div>
        </form> 
    </div>
     <!--Footer-->
<?php include('includes/footer.inc.php'); ?>
</div>
    </div>
</body>

</html>

<?php
 $user='root';
 $pass='root';
 $db='cinemafienddb';
 $conn = new mysqli('localhost',$user,$pass,$db) or die ("Unable to connect");
 if($conn)
 {
    echo "Your message has been sent";
 }
 else
 {
     echo"connection failed";
 }

	$sql= "INSERT INTO mails(name,email,message) values('$name','$email','$message')";
	if ($conn->query($sql) === true)
	{
			$contactname = $_POST['contact-name']; // HINT: use preg_replace() to filter the data
			$contactemail = $_POST['contact-email'];
			$contactmessage = nl2br($_POST['contact-message']);
			$to = "delalaktas@hotmail.com";	
			$from = $contactemail;
			$subject = 'Contact Form Message';
			$message = '<b>Name:</b> '.$contactname.' <br><b>Email:</b> '.$contactemail.' <p>'.$contactmessage.'</p>';
			$headers = "From: $from\n";
			$headers .= "MIME-Version: 1.0\n";
			$headers .= "Content-type: text/html; charset=iso-8859-1\n";
			if( mail($to, $subject, $message, $headers) ){
				echo "success";
			} 
			else 
			{
				echo "";
			}	
	 }
?>
// // GETTING ALL INPUT TEXT OBJECTS
// var username = document.forms["vform"]["username"];
// var email = document.forms["vform"]["email"];
// var message = document.forms["vform"]["message"];


// // GETTING ALL ERROR DISPLAY OBJECTS
// var name_error = document.getElementById("name_error");
// var email_error = document.getElementById("email_error");
// var message_error = document.getElementById("message_error");

// // SETTING ALL EVENT LISTENERS
// username.addEventListener("blur", nameVerify, true);
// email.addEventListener("blur", emailVerify, true);
// message.addEventListener("blur", messageVerify, true);

// //VALIDATION FUNCTION
// function Validate(){
//   //USERNAME VALIDATION
//   if(username.value == ""){
// 	username.style.border = "1px solid red";
// 	name_error.textContent = "Write your name";
// 	username.focus();
// 	return false;
//   }
//   //EMAIL VALIDATION
//   if(email.value == ""){
// 	email.style.border = "1px solid red";
// 	email_error.textContent = "Email is required";
// 	email.focus();
// 	return false;
//   }
//   //MESSAGE VALIDATION
//   if(message.value == ""){
// 	message.style.border = "1px solid red";
// 	message_error.textContent = "Input message";
// 	message.focus();
// 	return false;
//   }

  
// }
// //EVENT HANDLER FUNCTIONS
// function nameVerify(){
//   if(username.value != ""){
// 	username.style.border = "2px solid black";
// 	name_error.innerHTML = "";
// 	return true;
//   }
// }
// function emailVerify(){
//   if(email.value != ""){
// 	email.style.border = "2px solid black";
// 	email_error.innerHTML = "";
// 	return true;
//   }
// }
// function messageVerify(){
//   if(message.value != ""){
// 	message.style.border = "2px solid black";
// 	message_error.innerHTML = "";
// 	return true;
//   }
// }

function contactusformvalidation()
{
		function _(id){ return document.getElementById(id); }
			_("contact-submit-btn").disabled = true;// USER CANT PRESS OVER OVER AGAIN
			_("contact-status").innerHTML = 'Please wait for a moment ...'; //change status data is being process on server
			var formdata = new FormData(); // allow us to append new key value pairs into all the data thats going to be transmitted to php
			formdata.append( "contact-name", _("contact-name").value );
			formdata.append( "contact-email", _("contact-email").value );
			formdata.append( "contact-message", _("contact-message").value );
			var ajax = new XMLHttpRequest();
			ajax.open( "POST", "includes/contact-us.php" );
			ajax.onreadystatechange = function() {
				if(ajax.readyState == 4 && ajax.status == 200) { // basically that mean the data is finished processing by PHP and php returned data to this ajax
					if(ajax.responseText == "success"){
						_("contact-us-form").innerHTML = '<h2>Thank you for your message '+_("n").value+',  message has been sent we will.</h2>';
					} else {
						_("contact-status").innerHTML = ajax.responseText;
						_("contact-submit-btn").disabled = false;
					}
				}
			}
			ajax.send( formdata );
		

	}


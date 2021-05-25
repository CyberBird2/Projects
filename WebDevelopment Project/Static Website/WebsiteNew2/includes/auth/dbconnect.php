<?php
//--------------------Local and Online database connection-----------------------------
// // Localhost
// if ( $_SERVER["SERVER_ADDR"] == '::1' ) {
//     $servername = "localhost";
//     $username = "root";
//     $password = "root";
//     $dbname = "cinemafienddb";
// // Remote Host
// } else if ( $_SERVER["SERVER_ADDR"] === '84.241.204.202' ) {
//     $servername = "studmysql01.fhict.local";
//     $username = "dbi424999";
//     $password = "delalzgs123";
//     $dbname = "dbi424999";
// }
//---------------------------Hera database connection------------------------------------
//Define database variables
$servername = "studmysql01.fhict.local";
$username = "dbi424999";
$password = "delalzgs123";
$dbname = "dbi424999";
// Create connection
try
{
    $conn = new PDO("mysql:host=$servername;dbname=$dbname",$username,$password);
    $conn->setAttribute(PDO::ATTR_ERRMODE,PDO::ERRMODE_EXCEPTION);
    echo "";
}
catch(PDOException $e)
{
echo $sql."<br>" . $e->getmessage();
$conn=null;
}
//-------------------------Only local host connection-----------------------------------
//  $user='root';
//  $pass='root';
//  $db='cinemafienddb';
//  $conn = new mysqli('localhost',$user,$pass,$db) or die ("Unable to connect");

//  if($conn)
//  {
//     echo "Connection succesful";
//  }
//  else{
//      echo"connection failed";
//  }
?>

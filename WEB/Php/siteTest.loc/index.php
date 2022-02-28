<?php
include("config.php");
$username = $_POST['Login'];
$password = $_POST['Password'];
$score = $_POST['Score'];


$query = "SELECT * FROM users WHERE username='$username' AND password='$password'";
$results = mysqli_query($connections, $query);

$scorequery = "SELECT Score FROM users WHERE username='$username'";
$scoreResult = mysqli_query($connections,$scorequery);



if (mysqli_num_rows($results) == 1){
      echo("True ");
      echo(mysqli_fetch_assoc($scoreResult)['Score']);

}
      
      
    
    else {
      echo("False");

    }


      


    
$updateQuery = "UPDATE users SET Score ='$score' WHERE username = '$username'";
$updateResult = mysqli_query($connections,$updateQuery);






?>
<?php
    $dbUser = 'root';
    $dbPassword = '';
    $dbHostname = 'localhost';
    $dbName = 'gokkers';
    
    $dbHandle = new mysqli($dbHostname, $dbUser, $dbPassword, $dbName) or die($message = "Unable to connect to the MySQL database.");
    
    if (isset($_GET['email']) && !empty($_GET['email']) && filter_var($_GET['email'], FILTER_VALIDATE_EMAIL))
    {
        echo 'hoit';
        
        if (isset($_GET['password']) && !empty($_GET['password']))
        {
            $email = $_GET['email'];
            $password = $_GET['password'];
            echo 'hallot';
            $query = "INSERT INTO users(email, password) VALUES ('$email', '$password')";
            mysqli_query($dbHandle, $query);
            
        }
    
    }
    else
    {
        echo 'doeit';
    }
    
    header('Location: index.php');
    ?>
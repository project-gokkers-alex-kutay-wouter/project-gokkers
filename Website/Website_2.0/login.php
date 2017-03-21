<?php
    $dbUser = 'root';
    $dbPassword = '';
    $dbHostname = 'localhost';
    $dbName = 'gokkers';
    
    $dbHandle = new mysqli($dbHostname, $dbUser, $dbPassword, $dbName) or die($messageLogin = "Unable to connect to the MySQL database.");
    
    if (isset($_GET['email']) && !empty($_GET['email']) && filter_var($_GET['email'], FILTER_VALIDATE_EMAIL))
    {
        if (isset($_GET['password']) && !empty($_GET['password']))
        {
            $email = $_GET['email'];
            $password = $_GET['password'];
            $query = "SELECT * FROM users WHERE email = '$email' AND password = '$password'";
            mysqli_query($dbHandle, $query);
            if (mysqli_affected_rows($dbHandle) == 1)
            {
                $messageLogin = 'You have been logged in!';
            }
            else
            {
                $messageLogin = 'Please make sure your email and password are correct!';
            }
        }
    }
    else
    {
        $messageLogin = 'Please enter an email and password!';
    }
    
    header('Location: index.php?messageLogin=' . $messageLogin);
    exit();
    ?>
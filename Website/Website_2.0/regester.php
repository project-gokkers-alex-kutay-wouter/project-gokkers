<?php
    $dbUser = 'root';
    $dbPassword = '';
    $dbHostname = 'localhost';
    $dbName = 'gokkers';
    
    $dbHandle = new mysqli($dbHostname, $dbUser, $dbPassword, $dbName) or die($message = "Unable to connect to the MySQL database.");
    
    
    
    if (isset($_GET['email']) && !empty($_GET['email']) && filter_var($_GET['email'], FILTER_VALIDATE_EMAIL))
    {
        if (isset($_GET['password']) && !empty($_GET['password']))
        {
            $email = $_GET['email'];
            $password = $_GET['password'];
            $query = "SELECT email FROM users WHERE email = '$email'";
            mysqli_query($dbHandle, $query);
            if (mysqli_affected_rows($dbHandle) > 0)
            {
                $message =  'There is already an account with this email!';
            }
            else
            {
                $query = "INSERT INTO users(email, password) VALUES ('$email', '$password')";
                mysqli_query($dbHandle, $query);
                $message = 'Your account has been registered';
            }
        }
    }
    else
    {
        $message = 'Please enter an email and password!';
    }
    

    header('Location: index.php?message=' . $message);
    exit();
    ?>
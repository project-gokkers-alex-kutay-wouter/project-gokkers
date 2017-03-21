<!doctype html>
<html class="no-js" lang="">
<head>
    <meta charset="utf-8">
    <meta http-equiv="x-ua-compatible" content="ie=edge">
    <title></title>
    <meta name="description" content="">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <link rel="apple-touch-icon" href="apple-touch-icon.png">
    <!-- Place favicon.ico in the root directory -->

    <link rel="stylesheet" href="css/normalize.css">
    <link rel="stylesheet" href="css/main.css">
    <link href="https://fonts.googleapis.com/css?family=Alegreya" rel="stylesheet">
    <script src="js/vendor/modernizr-2.8.3.min.js"></script>
</head>
<body>
<div class="container">
<div class="header"><a name="home"></a>
    <div class="header-space-between">
        <div class="logo">
            <h2>Gokkers</h2>
        </div>
        <nav>
            <a href="#home">Home</a>
            <a href="#regester">Register</a>
            <a href="#download">Download Now</a>
        </nav>
    </div>
</div>

    <div class="homePage">
        <div class="index">
            <div class="intro">
                <h3>De Gokkers</h3>
                <h4>Summary</h4>
                <span>Welcome to the Gokkers application.</span>
                <p>This application is a game that simulates a betting game.</p>
            </div>

            <div class="game">
                <div class="app-info">

                    <div class="gameDescription">
                        <p>Description</p>
                        <p>The game has three players. The players are Sieste, Fer and Lidy. And there are five zebras.</p>
                        <p>Your goal is to pick one of the five zebras that are available. Pick your name, mark the button and bet.</p>
                        <p>When you win you will gain double the amount of what you bet, but if you lose, you will lose the money that you bet.</p>
                        <p>But watch out there. Weather is not so great in the Netherlands. It rains often!</p>
                    </div>

                    <div class="gameRules">

                        <p>Rules</p>
                            <ul>
                            <li>Minimum amount to bet = € 5,-</li>
                            <li>Maximum amount to bet = € 15,-</li>
                            <li>You can only bet on one zebra.</li>
                            <li>Every player can only bet on one Zebra.</li>
                            <li>When a bet is placed there is no changing it.</li>
                            <li>While the zebra are running the bets are closed off.</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="register"><a name="register"></a>
        <div class="register-center">
            <h2>register</h2>
            <form action="regester.php">
                <div class="form-group">
                    <label for="email">E-mail adres: </label>
                    <input type="email" name="email" id="email" required>
                    <label for="password">Password: </label>
                    <input type="password" name="password" id="password" required>
                    <input type="submit" id="submit" value="Verstuur">
                </div>
            </form>
        </div>
    </div>

    <div class="download">
        <div class="download-center">
            <h2><a href="download.php">Download</a></h2>
            <div class="login">
                <form action="">
                    <div class="form-group">
                        <label id="login" for="email">Login: </label>
                        <label for="email">E-mail adres: </label>
                        <input type="email" name="email" id="email" required>
                        <label for="password">Password: </label>
                        <input type="password" name="password" id="password" required>
                        <input type="submit" id="submit" value="Verstuur">
                    </div>
                </form>
            </div>
        </div>
    </div>
</div>
<script src="https://code.jquery.com/jquery-1.12.0.min.js"></script>
<script>window.jQuery || document.write('<script src="js/vendor/jquery-1.12.0.min.js"><\/script>')</script>
<script src="js/plugins.js"></script>
<script src="js/main.js"></script>

<!-- Google Analytics: change UA-XXXXX-X to be your site's ID. -->
<script>
    (function(b,o,i,l,e,r){b.GoogleAnalyticsObject=l;b[l]||(b[l]=
        function(){(b[l].q=b[l].q||[]).push(arguments)});b[l].l=+new Date;
        e=o.createElement(i);r=o.getElementsByTagName(i)[0];
        e.src='https://www.google-analytics.com/analytics.js';
        r.parentNode.insertBefore(e,r)}(window,document,'script','ga'));
    ga('create','UA-XXXXX-X','auto');ga('send','pageview');
</script>
</body>
</html>

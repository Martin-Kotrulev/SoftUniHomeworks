<!DOCTYPE html>
<!--Problem 1. Personal Info
Write a PHP script PersonalInfo.php. 
Declare a few variables. The first 
variable should hold your first name, 
the second should hold your last name, 
the third - your age, and the last one 
should hold your full name (use concatenation). 
The result should be printed.-->

<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
    </head>
    <body>
        <?php
            function printInfo($first, $last, $age) {
                print '<p>My name is ' . $first . ' ' . 
                        $last . ' and I am ' . 
                        $age . ' years old.</p>';
            }
            printInfo("Mister", "DakMan", 21);
            printInfo("Pesho", "Peshev", 55);
        ?>
    </body>
</html>

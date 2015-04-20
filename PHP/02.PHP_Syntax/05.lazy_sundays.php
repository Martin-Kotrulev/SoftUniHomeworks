<!DOCTYPE html>
<!--
Problem 5. Lazy Sundays
Write a PHP script LazySundays.php which prints the 
dates of all Sundays in the current month.
-->
<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
    </head>
    <body>
        <?php
        $month = date("m");
        $year = date("Y");
        for ($i = 1; $i < 32; $i++) {
            $dateString = $year . '-' . $month . '-' . $i;
            $newDate = new DateTime($dateString);
            $sunday = date_format($newDate, "l");
            if ($sunday == 'Sunday') {
                echo date_format($newDate, 'jS F, Y') . "<br>";
            }
        }
        ?>
    </body>
</html>

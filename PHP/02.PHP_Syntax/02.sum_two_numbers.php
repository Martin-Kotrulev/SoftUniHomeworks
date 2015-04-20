<!DOCTYPE html>
<!-- Problem 2. Sum Two Numbers
Write a PHP script SumTwoNumbers.php that 
decleares two variables, firstNumber and secondNumber. 
They should hold integer or floating-point numbers 
(hard-coded values). 
Print their sum in the output in the format shown 
in the examples below. 
The numbers should be rounded to the 
second number after the decimal point. 
Find in Internet how to round a given number in PHP. -->

<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
    </head>
    <body>
        <?php
        function sumTwo($n1, $n2) {
            printSum(number_format(round($n1 + $n2, 2), 2), $n1, $n2);
            echo '<br/>';
        }
        function printSum($sum, $n1, $n2) {
            echo '$firstNumber + secondNumber = ' . $n1 . ' + ' . $n1 . ' = ' . $sum;
        }
        sumTwo(1.567808, 0.356);
        sumTwo(1234.5678, 333);
        sumTwo(2, 5);
        ?>
    </body>
</html>

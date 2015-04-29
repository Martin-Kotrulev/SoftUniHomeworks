<!DOCTYPE html>
<!--
05. Sum of Digits
Write a PHP script SumOfDigits.php which receives a 
comma-separated list of integers from an input form 
and creates a two-column table. The first column should 
contain each of the values from the input. The second 
column should contain the sum of the digits of each value. 
If the value is not an integer number, print "I cannot sum 
that". Styling the page is optional.
-->
<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
        <style>
            table, td, tr {
                border: 1px solid black;
            }
        </style>
    </head>
    <body>
        <form method='GET' action='05.sum_of_digits.php'>
            <label for='main'>Input string:</label>
            <input type='text' id='main' name='input'>
            <input type='submit'/>
        </form>
        <?php

        /**
         * 
         * @param type $n
         * @return type
         */
        function sumDigits($n) {
            $sum = array_sum(str_split($n));            
            return $sum;
        }

        /**
         * 
         * @param type $values
         */
        function printValues($values) {
            echo '<table>';
            foreach ($values as $value) {
                echo '<tr>';
                echo '<td>'.$value.'</td>';
                if (intval($value)) {
                    echo '<td>'.sumDigits($value).'</td>';
                } else {
                    echo '<td>I cannot sum that!</td>';
                }
                echo '</tr>';
            }
            echo '</table>';
        }

        if (isset($_GET['input'])) {
            $values = explode(', ', $_GET['input']);
            printValues($values);
        }
        ?>
    </body>
</html>

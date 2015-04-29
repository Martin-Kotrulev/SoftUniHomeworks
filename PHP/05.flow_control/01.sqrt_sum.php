<!DOCTYPE html>
<!--
01. Square Root Sum
Write a PHP script SquareRootSum.php that displays a 
table in your browser with 2 columns. The first 
column should contain a number (even numbers 
from 0 to 100) and the second column should 
contain the square root of that number, rounded 
to the second digit after the decimal point. 
The last row of the table should contain the 
sum of all values in the Square column. 
Styling the page is optional.
-->
<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
        <style>
            table, td, tr {
                border: 1px solid black;
            }
            thead, .total {
                font-weight: bold;
            }
        </style>
    </head>
    <body>
        <table>
            <thead>
                <tr>
                    <td>Number</td>
                    <td>Square</td>
                </tr>
            </thead>
            <?php
                $sum = 0;
                for ($i = 0; $i<=100; $i += 2) {
                    $current = round(sqrt($i), 2);
                    echo '<tr>';
                    echo '<td>'.$i.'</td><td>'.$current.'</td>';
                    echo '<tr>';
                    $sum += $current;
                }
                echo '<tfoot><tr><td class="total">Total:</td><td>'.round($sum, 2).'</td></tr></tfoot>';
            ?>
        </table>
        
    </body>
</html>

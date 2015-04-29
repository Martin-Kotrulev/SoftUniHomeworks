<!DOCTYPE html>
<!--
To change this license header, choose License Headers in Project Properties.
To change this template file, choose Tools | Templates
and open the template in the editor.
-->
<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
        <style>
            thead {
                font-weight: bold;
            }
            table, tr, td {
                border: 1px solid black;
            }
        </style>
    </head>
    <body>
        <form method='GET' action='03.annual_expenses.php'>
            <label for='main'>Enter number of years:</label>
            <input type='text' id='main' name='n'/>
            <input type='submit' value='Show costs'/>
        </form>
        <?php

        /**
         * @param type $years
         */
        function printCosts($years) {
            ?>
            <table>
                <thead>
                    <tr>
                        <td>Year</td>
                        <td>January</td>
                        <td>February</td>
                        <td>March</td>
                        <td>April</td>
                        <td>May</td>
                        <td>June</td>
                        <td>July</td>
                        <td>August</td>
                        <td>September</td>
                        <td>October</td>
                        <td>November</td>
                        <td>December</td>
                        <td>Total</td>
                    </tr>
                </thead>
                <?php
                $current = intval(date('Y'));
                $end = $current - $years;
                for ($i = $current; $i >= $end; $i--) {
                    $sum = 0; 
                    $j = 12;
                    
                    echo '<tr>';
                    echo '<td>'.$i.'</td>';
                    while ($j) {
                        $value = rand(0, 999);
                        echo '<td>'.$value.'</td>';
                        $sum += $value;
                        $j--;
                    }
                    echo '<td>'.$sum.'</td>';
                    echo '</tr>';
                }
                ?>
            </table>
            <?php
        }

        if (isset($_GET['n'])) {
            $years = $_GET['n'];
            printCosts($years);
        }
        ?>
    </body>
</html>

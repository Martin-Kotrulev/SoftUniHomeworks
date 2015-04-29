<!DOCTYPE html>
<!--
02. Rich People’s Problems
You are a very rich billionaire with an unhidden 
passion for cars. You like certain car manufacturers 
but you don’t really care about anything else, and 
that’s why you need your own randomizing algorithm 
that helps you decide how many and what color cars 
you should buy. Write a PHP script 
CarRandomizer.php that receives a string of 
cars from an input HTML form, separated by a 
comma and space (“, “). It then prints each car, a 
random color and a random quantity in a table 
like the one shown below. Use colors by your choice. 
Use as quantity a random number in range [1...5]. 
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
            thead {
                text-align: center;
                font-weight: bold;
            }
        </style>
    </head>
    <body>
        <form method='GET' action='02.car_randomizer.php'>
            <label for='main'>Enter cars</label>
            <input type='text' id='main' name='cars'/>
            <input type='submit' value='Show result'/>
        </form>
        <?php
            /**
             *@param type $cars
             */
            function printCars($cars) {
                ?>
            <table>
                <thead>
                    <tr>
                        <td>Car</td>
                        <td>Color</td>
                        <td>Count</td>
                    </tr>
                </thead>
                <?php
                $colors = ['blue', 'yellow', 'red', 'black', 'gren'];
                foreach ($cars as $car) {
                    echo '<tr>';
                    echo '<td>'. $car . '</td><td>' .
                                 $colors[rand(0, count($colors) - 1)] .
                                 '</td><td>' . rand(1, 5) .
                                 '</td>';
                    echo '</tr>';
                }
                ?>
            </table>
            <?php
            }
            if(isset($_GET['cars'])) {
                $cars = explode(', ', $_GET['cars']);
                printCars($cars);
            }
        ?>
    </body>
</html>

<!DOCTYPE html>
<!--
Problem 3.	Dump Variable
Write a PHP script DumpVariable.php that declares a 
variable. If the variable is numeric, print it by t
he built-in function var_dump(). If the variable is 
not numeric, print its type at the input. 

-->
<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
    </head>
    <body>
        <?php
        function getVariableType($var) {
            if (is_numeric($var)) {
                echo var_dump($var);
            } else {
                echo gettype($var);
            }
            echo '<br/>';
        }

        getVariableType("hello");
        getVariableType(15);
        getVariableType(1.234);
        getVariableType(array(1, 2, 3));
        getVariableType((object) [2, 34]);
        ?>
    </body>
</html>

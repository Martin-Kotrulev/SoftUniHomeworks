<!DOCTYPE html>
<!--
02. Coloring Texts
Write a PHP program TextColorer.php that takes a text 
from a textfield, colors each character according to 
its ASCII value and prints the result. If the ASCII 
value of a character is odd, the character should be 
printed in blue. If it’s even, it should be printed in red.
-->
<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
    </head>
    <body>
        <form method='GET' action='02.coloring_texts.php'>
            <textarea name='main'></textarea>
            <input type='submit'>
        </form>
        <?php
            if (isset($_GET['main'])) {
                $text = preg_replace('/\s+/', '', $_GET['main']);
                for ($i = 0; $i < strlen($text); $i++) {
                    if (ord($text[$i]) % 2 == 0) {
                        echo '<span style="color:red"> ' . $text[$i] . ' </span>';
                    } else {
                        echo '<span style="color:blue"> ' . $text[$i] . ' </span>';
                    }
                }
            }
        ?>
    </body>
</html>

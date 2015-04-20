<!DOCTYPE html>
<!--Problem 4. Non-Repeating Digits
Write a PHP script NonRepeatingDigits.php that declares an i
nteger variable N, and then finds all 3-digit numbers that 
are less or equal than N (<= N) and consist of unique digits. 
Print "no" if no such numbers exist. 
-->

<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
    </head>
    <body>
        <?php
        function printUniqueNumbers($n) {
            $numbers = array();
            if (($n) >= 100) {
                for ($i = 100; $i <= $n; $i++) {
                    if ($i <= 999) {
                        $a = ($i / 10) % 10;
                        $b = ($i / 100) % 10;
                        $c = $i % 10;
                        if ($a != $b & $b != $c & $a != $c) {
                            $numbers[] = $i;
                        }
                    }
                }
            } else {
                echo('no');
            }
            
            if (count($numbers) > 0) {
                for ($i = 0; $i < count($numbers); $i++) {
                    echo $numbers[$i];
                    if ($i != count($numbers) - 1) echo ', ';
                }
            }
            
            echo '<br/><br/>';
        }
        echo printUniqueNumbers(1234);
        echo printUniqueNumbers(145);
        echo printUniqueNumbers(15);
        echo printUniqueNumbers(247);
        ?>
    </body>
</html>

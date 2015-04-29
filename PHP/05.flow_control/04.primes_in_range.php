<!DOCTYPE html>
<!--
04. Find Primes in Range
Write a PHP script PrimesInRange.php that receives two 
numbers – start and end – from an input field and displays 
all numbers in that range as a comma-separated list. 
Prime numbers should be bolded. Styling the page is optional.
-->
<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
    </head>
    <body>
        <form method='GET' action='04.primes_in_range.php'>
            <label for='start'>Starting Index: </label>
            <input type='text' id='start' name='start'/>
            <label for='end'>End:</label>
            <input type='text' id='end' name='end'/>
            <input type='submit'/>
        </form>
        <?php
        /**
         * @param type $n
         * @return boolean
         */
        function isPrime($n) {
           if ($n == 1 || $n == 2 || $n % 2 == 0) {
               return false;
           }
           for ($i = 3; $i <= ceil(sqrt($n)); $i += 2) {
               if ($n % $i == 0) {
                   return false;
               }
           }
           return true;
        }
        
        if (isset($_GET['start']) && isset($_GET['end'])) {
            $start = intval($_GET['start']);
            $end = intval($_GET['end']);
            for ($i = $start; $i <= $end; $i++) {
                if (isPrime($i)) {
                    echo '<b>' . $i . '</b>';
                } else {
                    echo $i;
                }
                if ($i != $end) {
                    echo ', ';
                }
            }
        }
        ?>
    </body>
</html>

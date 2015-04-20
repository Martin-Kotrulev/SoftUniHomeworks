<!DOCTYPE html>
<!--
02. Most Frequent Tag
Write a PHP script MostFrequentTag.php which 
generates an HTML input text field and a submit 
button. In the text field the user must enter 
different tags, separated by a comma and a 
space (", "). When the information is submitted, 
the script should generate a list of the tags, 
sorted by frequency. Then you must print: 
"Most Frequent Tag is: [most frequent tag]". 
Semantic HTML is required. Styling is not required.
-->
<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
    </head>
    <body>
        <?php

        function generateForm() { ?>
            <p>Test cases: Pesho, homework, homework, exam, course, PHP</p>
            <form action='' method='post'>
                <input type='text' name='main'/>
                <input type='submit'/>
            </form>
            <?php
        }

        function toAssoc($arr) {
            $assoc = [];
            foreach ($arr as $e) {
                if (array_key_exists($e, $assoc)) {
                    $assoc[$e] ++;
                } else {
                    $assoc[$e] = 1;
                }
            }
            return $assoc;
        }

        generateForm();
        if (isset($_POST['main'])) {
            $arr = explode(', ', $_POST['main']);
            $arr = toAssoc($arr);
            uasort($arr, function($a, $b) {
                return $b - $a;
            });
            $max = 0;
            foreach ($arr as $key => $value) {
                print '<p>' . $key . ' : ' . $value . '</p>';
                if ($value > $max) {
                    $max = $value;
                }
            }
            print '<br/>';
            print 'Most frequent tag is: ' . $max;
        }
        ?>
    </body>
</html>

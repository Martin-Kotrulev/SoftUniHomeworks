<!DOCTYPE html>
<!--
01. Word Mapping
Write a PHP program WordMapper.php that takes a text 
from a textarea and prints each word and the number of 
times it occurs in the text. The search should be 
case-insensitive. The result should be printed as 
an HTML table.
-->
<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
        <style>
            table, tr, td {
                background-color: lightgrey;
                border: 1px solid black;
            }
        </style>
    </head>
    <body>
        <form method='GET' action='01.word_mapping.php'>
            <textarea rows='3' cols='50' name='main'></textarea></br>
            <input type='submit' value='Count words'/>
        </form>
        <?php
        /**
         * 
         * @param type $arr
         */
        function printTableCount($arr) {
            echo '<table>';
            foreach($arr as $key => $value) {
                echo '<tr>';
                echo '<td>'. $key . '</td><td>' . $value . '</td>';
                echo '</tr>';
            }
            echo '</table>';
        }
        
        /**
         * 
         * @param type $words
         * @return type
         */
        function countWords($words) {
            $result = array();
            foreach ($words as $word) {
                if (!key_exists($word, $result)) {
                    $result[$word] = 1;
                } else {
                    $result[$word]++;
                }
            }
            return $result;
        }

        if (isset($_GET['main'])) {
            $text = strtolower($_GET['main']);
            $text = trim(preg_replace('/[^a-z]/', ' ', $text));
            $words = preg_split('/\s+/', $text);
            
            printTableCount(countWords($words));
        }
        ?>
    </body>
</html>

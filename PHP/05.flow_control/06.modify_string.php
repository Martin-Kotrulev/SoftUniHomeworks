<!DOCTYPE html>
<!--
06. Modify String
Write a PHP script StringModifier.php which receives a 
string from an input form and modifies it according to 
the selected option (radio button). You should support 
the following operations: palindrome check, reverse string, 
split to extract leters only, hash the string with the 
default PHP hashing algorithm, shuffle the string 
characters randomly. The result should be displayed 
right under the input field. Styling the page is 
optional. Think about which of the modification can 
be achieved with already built-in functions in PHP. 
Where necessary, write your own algorithms to modify 
the given string. Hint: Use the crypt() function for 
the "Hash String" modification. 
-->
<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
    </head>
    <body>
        <form method='GET' action='06.modify_string.php'>
            <input type='text' name='main'/>
            <input type='radio' name='mod' checked value='pal'> Check Palindrome
            <input type='radio' name='mod' value='rev'> Reverse String
            <input type='radio' name='mod' value='spl'> Split
            <input type='radio' name='mod' value='hash'> Hash String
            <input type='radio' name='mod' value='shuff'> Shuffle String
            <input type='submit'>
        </form>
        <?php
        /**
         * 
         * @param type $s
         * @return boolean
         */
        function isPalindrome($s) {
            $len = strlen($s) - 1;
            for ($i = 0, $j = $len; $i <= floor($len / 2); $i++, $j--) {
                if ($s[$i] != $s[$j]) {
                    return false;
                }
            }
            return true;
        }

        if (isset($_GET['main'])) {
            $s = $_GET['main'];
            switch ($_GET['mod']) {
                case 'pal': echo $s . ' is ' . (isPalindrome($s) ? '' : ' not ') . ' palindrome!';
                    break;
                case 'rev': echo strrev($s);
                    break;
                case 'spl': foreach (str_split($s) as $c) echo $c . ' ';
                    break;
                case 'hash': echo crypt($s, '*!');
                    break;
                case 'shuff': echo str_shuffle($s);
                default: break;
            }
        }
        ?>
    </body>
</html>

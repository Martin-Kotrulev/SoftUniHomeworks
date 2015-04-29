<!DOCTYPE html>
<!--
Text Filter
Write a PHP program TextFilter.php that takes a text 
from a textfield and a string of banned words from a text 
input field. All words included in the ban list should be 
replaced with asterisks "*", equal to the word’s length. 
The entries in the banlist will be separated by a comma 
and space ", ".
-->
<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
    </head>
    <body>
        <form method='POST' action='04.text_filter.php'>
            <textarea name='main'>It is not Linux, it is GNU/Linux. Linux is merely the kernel, while GNU adds the functionality. Therefore we owe it to them by calling the OS GNU/Linux! 
Sincerely, a Windows client</textarea></br>
            <input type='text' name='ban' value='Linux, Windows'/>
            <input type='submit'>
        </form>
        <?php
            if (isset($_POST['main']) && isset($_POST['ban'])) {
                $text = $_POST['main'];
                $ban = explode(', ', $_POST['ban']);
                foreach ($ban as $word) {
                    $text = str_replace($word, str_repeat('*', strlen($word)), $text);
                }
                echo '<p>' . $text . '</p>';
            }
        ?>
    </body>
</html>

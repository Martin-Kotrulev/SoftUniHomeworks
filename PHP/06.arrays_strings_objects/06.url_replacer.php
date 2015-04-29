<!DOCTYPE html>
<!--
06. URL Replacer
Write a PHP program URLReplacer.php that takes a text 
from a textarea and replaces all URLs with the HTML 
syntax <a href= "…" ></a> with a special forum-style 
syntax [URL=…][/URL].
-->
<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
    </head>
    <body>
        <form method='POST' action='06.url_replacer.php'>
            <form method='POST' action='04.text_filter.php'>
            <textarea name='main'><p>Come and visit <a href="http://softuni.bg">the Software University</a> to master the art of programming. You can always check our <a href="www.softuni.bg/forum">forum</a> if you have any questions.</p></textarea></br>
            <input type='submit'>
        </form>
        <?php
        if (isset($_POST['main'])) {
            $text = $_POST['main'];
            $pattern= '/(<a.*? href)=(\'|\"|)(.*?)\2>([^<]+)(<\/a>)/';
            $replacement='[URL=\3]\4[/URL]';
            echo preg_replace($pattern,$replacement,$text);
        }
        ?>
    </body>
</html>

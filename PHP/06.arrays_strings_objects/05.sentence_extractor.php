<!DOCTYPE html>
<!--
05. Sentence Extractor
Write a PHP program SentenceExtractor.php that takes a 
text from a textarea and a word from an input field and 
prints all sentences from the text, containing that word. 
A sentence is any sequence of words ending with ., ! or ?.
-->
<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
    </head>
    <body>
        <form method='POST' action='05.sentence_extractor.php'>
            <textarea name='main'>This is my cat! And this is my dog. We happily live in Paris – the most beautiful city in the world! Isn’t it great? Well it is :)</textarea><br/>
            <input type='text' name='key'/>
            <input type='submit'/>
        </form>
        <?php
            if (isset($_POST['main']) && isset($_POST['key'])) {
                $count = preg_match_all('/[^!.?]*\s+(' . $_POST['key'] . ')\s+[^!.?]*[!?.]/', $_POST['main'], $matches);
           
                foreach ($matches[0] as $sentence) {
                    echo '<p>' . $sentence . '</p>';
                }
            }
        ?>
    </body>
</html>


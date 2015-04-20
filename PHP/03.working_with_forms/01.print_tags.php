<!DOCTYPE html>
<!--
01. Print Tags
Write a PHP script PrintTags.php which generates an 
HTML input text field and a submit button. In the 
text field the user must enter different tags, 
separated by a comma and a space (", "). When 
the information is submitted, the script should 
split the tags, put them in an array and print 
out the array. Semantic HTML is required. Styling 
is not required. 
-->
<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
    </head>
    <body>
        <?php

        function generateForm() {
            ?>
            <p>Test cases: Pesho, homework, homework, exam, course, PHP</p>
            <p>Enter text:</p>
            <form action='' method='post'>
                <input type='text' name='main'>
                <input type='submit'>
            </form>
            <?php
        }
        
        generateForm();
        if (isset($_POST['main'])) {
            $arr = explode(', ', $_POST['main']);
            foreach ($arr as $key => $value) {
                print $key . ' : ' . $value;
                print '<br/>';
            }
        }
        ?>
    </body>
</html>

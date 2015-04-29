<!DOCTYPE html>
<!--
Problem 4. HTML Tags Counter
Write a PHP script HTMLTagsCounter.php which generates an 
HTML form like in the example below. It should contain a label, 
an input text field and a submit button. The user enters HTML 
tag in the input field. If the tag is valid, the script 
should print “Valid HTML tag!”, and if it is invalid – 
“Invalid HTML Tag!”. On the second line, there should be 
a score counter. For every valid tag entered, the score 
should increase by 1.
Hint: You may use sessions. Use an array to store all 
valid HTML5 tags.
-->
<?php
session_start();
?>
<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
    </head>
    <body>
        <?php

        function generateForm() { ?>
            <p>Enter HTML tags:</p>
            <form action='04.html_tag_counter.php' method="post">
                <input type="text" name="main"/>
                <input type="submit"/>
            </form>
            <?php
        }

        if (!isset($_SESSION['score'])) {
            $_SESSION['score'] = 0;
        }
        $_SESSION['tags'] = [
            '!DOCTYPE', 'html', 'base', 'head', 'link', 'meta',
            'style', 'title', 'address', 'article',
            'body', 'footer', 'header', 'h1', 'h2', 'h3',
            'h4', 'h5', 'h6', 'hgroup', 'nav', 'section',
            'dd', 'div', 'dl', 'dt', 'figcaption', 'figure',
            'hr', 'li', 'main', 'ol', 'p', 'pre', 'ul', 'a',
            'abbr', 'b', 'bdi', 'bdo', 'br', 'cite', 'code',
            'date', 'dfn', 'em', 'i', 'kbd', 'mark', 'q', 'rp',
            'rt', 'rtc', 'ruby', 's', 'samp', 'small', 'span',
            'strong', 'sub', 'sup', 'time', 'time', 'u', 'var',
            'wbr', 'area', 'audio', 'img', 'map', 'track',
            'video', 'embed', 'iframe', 'object', 'param',
            'source', 'canvas', 'noscript', 'script', 'del',
            'ins', 'caption', 'col', 'colgroup', 'table',
            'tbody', 'td', 'foot', 'th', 'thead', 'tr', 'button',
            'datalist', 'fieldset', 'form', 'input', 'keygen',
            'label', 'legend', 'meter', 'optgroup', 'option',
            'output', 'progress', 'select', 'textarea',
            'details', 'dialog', 'menu', 'menuitem', 'summary',
            'content', 'decorator', 'element', 'shadow', 'template',
            'acronym', 'applet', 'basefront', 'big', 'blink',
            'center', 'dir', 'frame', 'frameset', 'isindex',
            'listing', 'noembed', 'plaintext', 'spacer', 'strike',
            'tt', 'xmp'
        ];

        
        generateForm();
        if (isset($_POST['main'])) {
            if (in_array($_POST['main'], $_SESSION['tags'])) {
                $index = array_search($_POST['main'], $_SESSION['tags']);
                print '<h1>Valid HTML tag!</h1>';
                $_SESSION['score']++;
            } else {
                print '<h1>Invalid HTML tag!</h1>';
            }
            print '<h2>Score: ' . $_SESSION['score'] . '</h2';
        }
        
        ?>
    </body>
</html>

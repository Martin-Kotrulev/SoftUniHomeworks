<!DOCTYPE html>
<!--
03. Sidebar Builder
Write a PHP program SidebarBuilder.php that takes data 
from several input fields and builds 3 sidebars. 
The input fields are categories, tags and months. 
The first sidebar should contain a list of the 
categories, the second sidebar – a list of the 
tags and the third should contain the months. 
The entries in the input strings will be separated 
by a comma and space ", ". Styling the page is optional. 
Semantic HTML is required.
-->
<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
        <style>
            form {
                width: 350px;
                float: left;
            }
            input[type='text'] {
                width: 250px;
            }
            aside {
                float: right;

            }
            ul {
                list-style: circle;
            }
            a {
                color: black;
            }
            section {
                border: 1px solid black;
                background-color: #CAD8E8;
                border-radius: 20px;
                margin: 10px;
                padding-left: 10px;
            }
            h1 {
                border-bottom: 1px solid black;
            }
        </style>
    </head>
    <body>
        <form method='GET' action='03.sidebar_builder.php'>
            <label for='categories'>Categories:</label>
            <input type='text' name='categories' id='categories' value='Knitting, Cycling, Swimming, Dancing'/><br/>
            <label for='tags'>Tags:</label>
            <input type='text' name='tags' id='tags' value='person, free time, love, peace, protest'/><br/>
            <label for='months'>Months:</label>
            <input type='text' name='months' id='months' value='April, May, June, July'/><br/>
            <input type='submit'/>
        </form>
        <?php

        /**
         * 
         * @param type $items
         * @param type $header
         */
        function printListItems($items, $header) {
        ?>
            <section>
                <h1><?= $header ?></h1>
                <ul>
                    <?php foreach ($items as $item) : ?>
                        <li><a href='#'><?= $item ?></a></li>
                    <?php endforeach ?>
                </ul>
            </section>
        <?php
        }

        if (isset($_GET['categories']) &&
                isset($_GET['tags']) &&
                isset($_GET['months'])) {
            $cat = explode(', ', $_GET['categories']);
            $tags = explode(', ', $_GET['tags']);
            $months = explode(', ', $_GET['months']);
            ?>
            <aside>
                <?php
                printListItems($cat, 'Categories');
                printListItems($tags, 'Tags');
                printListItems($months, 'Months');
                ?>
            </aside>
        <?php
        }
        ?>
    </body>
</html>

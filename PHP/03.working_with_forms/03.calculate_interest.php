<!DOCTYPE html>
<!--
03. Calculate Intereste
Write a PHP script CalculateInterest.php which 
generates an HTML 
page that contains:
An input text field to hold the amount of money
Radio buttons to choose the currency
An input text field to enter the compound 
annual interest amount
A dropdown menu to choose the period of time
A submit button
When the information is submitted, the script 
should print out the amount of money you will 
have after the selected period, rounded to 2 
decimal places. Semantic HTML is required. 
Styling is not required. 
-->
<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
    </head>
    <body>
        <?php

        function generateForm() { ?>
            <form action='' method='post'>
                <section>
                    <label for='amount'>Enter Amount</label>
                    <input type='text' name='amount' id='amount'/>
                </section>
                <section>
                    <input type='radio' name='currency' id='usd' value='usd' checked/>
                    <label for='usd'>USD</label>
                    <input type='radio' name='currency' id='eur' value='eur'/>
                    <label for='eur'>EUR</label>
                    <input type='radio' name='currency' id='bgn' value='bgn'/>
                    <label for='bgn'>BGN</label>
                </section>
                <section>
                    <label for='interest'>Compound Interest Amount</label>
                    <input type='text' name='interest' id='interest'/>
                </section>
                <select name='period'>
                    <option value='6'>6 months</option>
                    <option value='12'>1 year</option>
                    <option value='24'>2 years</option>
                    <option value='60'>5 years</option>
                </select>
                <input type='submit'/>
        </form>
        <?php
    }

    generateForm();
    
    if(isset($_POST['amount'], $_POST['interest'], $_POST['period']) &&
            $_POST['amount'] != null && $_POST['interest'] != null && $_POST['period'] != null) {
        $amount = $_POST['amount'];
        $interest = $_POST['interest'];
        $currency = $_POST['currency'];
        $period = $_POST['period'];
        $result = round($amount * pow(1 + (($interest / 100) / 12), $period / 12 * 12), 2);
        
        switch($_POST['currency']) {
            case 'usd': print '$ ' . $result; break;
            case 'eur': print '€ ' . $result; break;
            case 'bgn': print $result . ' Lv.';
        }
    }

    ?>
</body>
</html>

/**
  * 04. Count Number of DIVs
  * Write a JavaScript function countDivs(html) to count the number of
 * all DIVs in given HTML fragment passed as string. Write a JS program
 * countOfDivs.js that invokes your function and prints the output at the console.
 */
function countOfDivs(html) {
    var count = html.match(/\/div/g); // /g global modifier returns all matches array
    console.log(count.length);
}

countOfDivs('<!DOCTYPE html>' +
'<html>\n' +
'<head lang="en">' +
'<meta charset="UTF-8">' +
'<title>index</title>' +
'<script src="/yourScript.js" defer></script>' +
'</head>' +
'<body>' +
'<div id="outerDiv">' +
'<div' +
'class="first">' +
'<div><div>hello</div></div>' +
'</div>' +
'<div>hi<div></div></div>' +
'<div>I am a div</div>' +
'</div>' +
'</body>' +
'</html>');
/*
 * 01. Current Time
 * Write a JavaScript program current-time.js that prints on the console
 * the current time in UTC format.
 * Execute your file through Node.js. A sample output is given below:
 */

var current = new Date();
console.log(current.toUTCString());
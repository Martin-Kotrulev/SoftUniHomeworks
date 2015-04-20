/*
 * Calculate knots
 * Write a JavaScript function that accepts a number
 * variable to convert from km/h to knots (knot is a
 * maritime unit measuring speed). The result should
 * be printed on the console, rounded up to the second
 * sign after the decimal point. Run the program through Node.js.
 *
 */

function kmhToKnot(kmh) {
    var knotValue = 0.539956803
    console.log((knotValue * kmh).toFixed(2));
}

kmhToKnot(20);
kmhToKnot(112);
kmhToKnot(400);
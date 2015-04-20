/*
 * 01. Quadratic equation
 * Write a script that enters the coefficients a, b and c of a
 * quadratic equation a*x2 + b*x + c = 0 and calculates and prints
 * its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.
 */

function getRealRoots(a, b, c) {
    var discriminant = Math.pow(b, 2) - 4 * a * c;
    if (discriminant > 0) {
        var x1 = (-b - Math.sqrt(discriminant)) / (2 * a),
            x2 = (-b + Math.sqrt(discriminant)) / (2 * a);
        console.log('x1 = ' + x1);
        console.log('x2 = ' + x2);
    } else if (discriminant === 0) {
        var x = -b / (2 * a);
        console.log('x = ' + x);
    } else {
        console.log('No real roots');
    }
}

getRealRoots(2, 5, -3);
getRealRoots(2, -4, 2);
getRealRoots(4, 2, 1);
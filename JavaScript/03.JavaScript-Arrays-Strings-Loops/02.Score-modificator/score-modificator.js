/**
 * 02. Score modification
 * You are given an array of numbers. Your tasks are to
 * first filter out all valid exam scores (between 0 and 400) and
 * afterwards scale them downwards by removing 20% out of each score.
 * Finally you should print out the changed scores sorted in ascending order.
 */

function getValidScores(input) {
    var validScore = input.filter(function (a) {
        if (a >= 0 && a <= 400) {
            return a;
        }
    });

    var scaleValidScore = validScore.map(function (a) {
        return Number((a * 0.8).toFixed(1));
    });

    scaleValidScore = scaleValidScore.sort(function (a, b) {
        return a > b;
    });

    console.log(scaleValidScore);
}

getValidScores([200, 120, 23, 67, 350, 420, 170, 212, 401, 615, -1]);
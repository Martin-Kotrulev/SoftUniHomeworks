/**
 * 01. Array manipulator
 * You are given an array of objects. Your task is to write a JavaScript
 * code that filters out the numbers of that array (removes all non-number objects).
 * Then you should: 1. Find the Min number, 2. Find the Max number,
 * 3. Find the most frequent number. Finally you should print out the
 * numbers you have found and the filtered array sorted in descending order.
 */

function filterNumbers(input) {

    var numbers = input.filter(function (a) {
        return !isNaN(a);
    });

    var numbersSorted = numbers.sort(function (a, b) {
        return a > b;
    });

    var maxCtr = 0,
        frequent = 0;

    for (var i = 0; i < numbers.length; i++) {
        var count = 1;
        for (var j = i+1; j < numbers.length; j++) {
            if(numbers[i] === numbers[j]){
                count++;
            }
            if(count > maxCtr){
                maxCtr = count;
                frequent = numbers[i];
            }
        }
    }

    var minNumber = numbersSorted[0];
    var maxNumber = numbersSorted[numbersSorted.length-1];

    console.log('Min number: ' + minNumber);
    console.log('Max number: ' + maxNumber);
    console.log('Most frequent number: ' + frequentNumber);
    console.log(numbersSorted.reverse());

}

filterNumbers(["Pesho",
    2,
    "Gosho",
    12,
    2,
    "true",
    9,
    undefined,
    0,
    "Penka",
    { bunniesCount : 10},
    [10, 20, 30, 40]
]);
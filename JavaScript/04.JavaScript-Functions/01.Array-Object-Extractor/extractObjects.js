/**
 * 01. Array object extractor
 * Write a JavaScript function extractObjects(array).
 * As a function argument you are given an array of different
 * objects with different data types .
 * Your task is to write the JavaScript function that filters
 * out the Objects (all primitive data type objects and arrays
 * are filtered) and returns a new array with the extracted elements.
 */
function extractObjects(array) {
    var out = [];
    for (var i in array) {
        if (typeof array[i] === 'object' && !Array.isArray(array[i])) {
            out.push(array[i]);
        }
    }
    return out;
}

console.log(extractObjects([
    "Pesho",
    4,
    4.21,
    { name : 'Valyo', age : 16 },
    { type : 'fish', model : 'zlatna ribka' },
    [1,2,3],
    "Gosho",
    { name : 'Penka', height: 1.65}
]));

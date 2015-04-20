/**
 * 02. String's letters organizer
 * Write a JavaScript function sortLetters(string, boolean) that gets
 * as an input a string and a boolean. The function sorts all letters
 * in the string in alphabetical order and returns the newly
 * formed string. The sorting is ascending if the boolean is
 * true otherwise the sorting is in descending order.
 * Example: Note: The sorting is case-insensitive but
 * the output should use the same casing as the input!
 *  Hint: You are allowed to use .sort() function.
 */
function sortLetters(string, boolean) {
    var out = string.split('');

    out.sort(function (a, b) {
        if (boolean) {
          return a.toLowerCase() > b.toLowerCase();
        }
        return b.toLowerCase() > a.toLowerCase();
    });
    return out.join('');
}

console.log(sortLetters('HelloWorld', true));
console.log(sortLetters('HelloWorld', false));
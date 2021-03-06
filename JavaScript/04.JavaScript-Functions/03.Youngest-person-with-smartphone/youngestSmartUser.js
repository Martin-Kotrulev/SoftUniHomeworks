/**
 * Find Youngest Person that has a smartphone
 * Write a JavaScript function findYoungestPerson(array) that
 * accepts as parameter an array of people, finds the youngest
 * person that has a smartphone and returns his full name.
 * Write a JS program youngestPerson.js to execute your
 * function for the below examples and print the result at the console.
 */
function foundYoungestPerson(array) {
    array = array.filter(function(person) {
        if (person.hasSmartphone) {
            return person;
        }
    });
    array.sort(function(a, b){
        return a.age > b.age;
    });
    return array[0];
}

var people = [
    { firstname : 'George', lastname: 'Kolev', age: 32, hasSmartphone: false },
    { firstname : 'Vasil', lastname: 'Kovachev', age: 40, hasSmartphone: true },
    { firstname : 'Bay', lastname: 'Ivan', age: 81, hasSmartphone: true },
    { firstname : 'Baba', lastname: 'Ginka', age: 40, hasSmartphone: false }
];

console.log(foundYoungestPerson(people));
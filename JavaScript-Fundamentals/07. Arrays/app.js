let task4 = require('./Problem04/MaximalIncreasingSequence.js');
let task5Solve = require('./Problem05/SelectionSort.js');

let task4test = ['8', '7', '3', '2', '3', '4', '2', '2', '4'];

let task5Tests = [
    ['6', '3', '4', '1', '5', '2', '6'],
    ['10', '36', '10', '1', '34', '28', '38', '31', '27', '30', '20']
]

task5Tests.forEach(test => task5Solve(test));
function solve(values) {
    var a = +values[0],
        b = +values[1],
        c = +values[2];

    if (a * b * c < 0) {
        console.log('-');
    } else if (a * b * c > 0) {
        console.log('+');
    } else {
        console.log('0');
    }
}
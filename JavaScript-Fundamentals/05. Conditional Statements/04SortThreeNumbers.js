function solve(values) {
    var a = +values[0],
        b = +values[1],
        c = +values[2];

    if (a < b) {
        if (b < c) {
            console.log(c + ' ' + b + ' ' + a);
        } else {
            console.log(b + ' ' + c + ' ' + a);
        }
    } else if (b < c) {
        if (c < a) {
            console.log(a + ' ' + c + ' ' + b);
        } else {
            console.log(c + ' ' + a + ' ' + b);
        }
    } else if (c < a) {
        if (a < b) {
            console.log(b + ' ' + a + ' ' + c);
        } else {
            console.log(a + ' ' + b + ' ' + c);
        }
    } else {
        console.log(a + ' ' + b + ' ' + c);
    }
}
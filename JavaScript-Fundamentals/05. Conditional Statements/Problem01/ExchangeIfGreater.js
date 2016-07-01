function exchange(values) {
    var a = +values[0],
        b = +values[1];

    if (a > b) {
        console.log(b + ' ' + a);
    } else {
        console.log(a + ' ' + b);
    }
}
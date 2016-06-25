function biggestThree(values) {
    var a = +values[0],
        b = +values[1],
        c = +values[2],
        max = a;

    if (max < b) {
        max = b;
        if (max < c) {
            max = c;
        }
    } else if (max < c) {
        max = c;
    }
    console.log(max);
}
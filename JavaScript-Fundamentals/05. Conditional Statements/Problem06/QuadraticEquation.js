function quadraticEquation(number) {
    var a = +number[0],
        b = +number[1],
        c = +number[2];

    var D = Math.pow(b, 2) - 4 * a * c;
    if (D == 0) {
        var x = -b / (2 * a);
        console.log('x1=x2=' + x.toFixed(2));
    } else if (D < 0) {
        console.log("no real roots");
    } else {
        var x2 = (-b - Math.sqrt(D)) / (2 * a),
            x1 = (-b + Math.sqrt(D)) / (2 * a);
        if (x1 < x2) {
            console.log('x1=' + x1.toFixed(2) + '; ' + 'x2=' + x2.toFixed(2));
        } else {
            console.log('x1=' + x2.toFixed(2) + '; ' + 'x2=' + x1.toFixed(2));
        }
    }
}
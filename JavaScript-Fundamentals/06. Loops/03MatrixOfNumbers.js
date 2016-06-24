function matrix(number) {

    var num = +number[0];
    var res = '';

    for (var i = 1; i <= num; i += 1) {
        for (var j = i; j <= i + num - 1; j += 1) {
            res += j + ' ';
        }
        res += '\n';
    }

    console.log(res);
}
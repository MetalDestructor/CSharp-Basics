function numbers(theNum) {
    var num = +theNum[0];

    var res = '';
    for (var i = 1; i <= num; i += 1) {
        res += ' ' + i;
    }
    console.log(res);
}
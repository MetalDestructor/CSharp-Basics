function solve(args) {
    args = args[0].split('\n').map(Number);
    var n = args[0];

    for (var i = 1; i < n; i += 1) {
        var min = i;
        for (var j = 0; j < n; j += 1) {
            if (args[min] < args[j]) {
                min = j;
                var temp = args[min];
                args[min] = args[i];
                args[i] = temp;
            }
        }
    }

    for (var k = 1; k < n; k += 1) {
        console.log(args[k]);
    }
}


module.exports = solve;
function solve(numbers) {
    var max = +numbers[0];
    for (var i = 0; i < 5; i += 1) {
        if (max < +numbers[i]) {
            max = +numbers[i];
        }
    }
    console.log(max);
}
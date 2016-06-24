function solve(arr) {
    var a = +arr[0];
    var b = +arr[1];
    var h = +arr[2];

    var area = ((a + b) / 2) * h;
    console.log(area.toFixed(7));
}
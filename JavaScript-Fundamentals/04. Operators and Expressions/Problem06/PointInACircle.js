function pointInCircle(arr) {
    var x = arr[0];
    var y = arr[1];
    var condition = Math.pow((x - 0), 2) + Math.pow((y - 0), 2);
    if (condition <= Math.pow(2, 2)) {
        console.log('yes ' + Math.sqrt(condition).toFixed(2));
    } else {
        console.log('no ' + Math.sqrt(condition).toFixed(2));
    }
}
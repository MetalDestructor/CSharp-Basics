function areaAndPerimeter(arr) {
    var width = arr[0];
    var height = arr[1];
    var area = width * height;
    var perimeter = 2 * width + 2 * height;
    console.log(area.toFixed(2) + " " + perimeter.toFixed(2));
}
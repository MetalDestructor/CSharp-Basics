function mmsa(nums) {
    var size = nums.length;
    var min = +nums[0];
    for (var i = 0; i < size; i++) {
        if (+nums[i] < min) {
            min = +nums[i];
        }
    }
    var max = +nums[0];
    for (i = 0; i < size; i++) {
        if (+nums[i] > max) {
            max = +nums[i];
        }
    }
    var sum = 0.0;
    for (i = 0; i < size; i++) {
        sum += +nums[i];
    }
    var avarage = sum / size;
    console.log('min=' + min.toFixed(2));
    console.log('max=' + max.toFixed(2));
    console.log('sum=' + sum.toFixed(2));
    console.log('avg=' + avarage.toFixed(2));
}
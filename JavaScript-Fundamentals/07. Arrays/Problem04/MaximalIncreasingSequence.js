function solve(args) {
    args = args[0].split('\n');
    var n = +args[0],
        i,
        maxCount = 0,
        currentCount = 1;

    for (i = 1; i < n - 1; i += 1) {
        while (+args[i] < +args[i + 1]){
            currentCount +=1;
            i+=1;
        }   
        if (maxCount < currentCount) {
            maxCount = currentCount;
        }
        currentCount = 1;
    }
    console.log(maxCount);
    
}

module.exports = solve;
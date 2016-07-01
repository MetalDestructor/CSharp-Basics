function compare(args) {
    var first = args[0].split('\n')[0],
        second = args[0].split('\n')[1];

    if (first < second) {
        console.log('<');
    } else if (first > second) {
        console.log('>');
    } else {
        console.log('=');
    }
}
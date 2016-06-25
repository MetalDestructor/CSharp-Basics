function primeCheck(num) {
    var result = true;
    if (num == 0 || num == 1) {
        result = false;
    } else if (num == 2 || num == 3 || num == 5 || num == 7) {
        result = true;
    } else if (num % 2 == 0 || num % 3 == 0 || num % 5 == 0 || num % 7 == 0) {
        result = false;
    } else {
        result = true;
    }
    if (result == true) {
        console.log('true');
    } else {
        console.log('false');
    }
}
function thirdBitFunc(num) {
    var mask = 1 << 3;
    var temp = mask & num;
    var thirdBit = temp >> 3;

    return thirdBit;
}
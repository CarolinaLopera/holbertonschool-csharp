using System;


class Number {
    public static int PrintLastDigit(int number) {
        if (number < 0) {
            number = number * - 1;
        }
        return (number % 10);
    }
}

using System;

class Line {
    public static void PrintLine(int length) {
        if (length == 0 || length < 0) {
            Console.WriteLine();
            return;
        }
        for (int i = 1; i <= length; i++) {
            Console.Write("_");
            if (i == length) {
                Console.WriteLine();
            }
        }
    }
}

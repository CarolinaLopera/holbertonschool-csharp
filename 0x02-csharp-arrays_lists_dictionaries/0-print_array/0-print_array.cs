using System;

class Array {
    public static int[] CreatePrint(int size) {
        if (size < 0) {
            Console.WriteLine("Size cannot be negative");
            return null;
        } else if (size == 0) {
            Console.WriteLine();
        }

        int[] array = new int[size];
        for (int i = 0; i < size; i ++) {
            array[i] = i;
            if (i != size - 1) {
                Console.Write($"{i} "); 
            } else {
                Console.Write($"{i}\n"); 
            }
        }
        return array;
    }
}

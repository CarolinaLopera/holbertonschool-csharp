using System;

class List {
	public static List<int> CreatePrint(int size) {
		if (size < 0) {
		    Console.WriteLine("Size cannot be negative");
		    return null;
		} else if (size == 0) {
		    Console.WriteLine();
		}

		List<int> list = new List<int>();
		for (int i = 0; i < size; i++) {
		    list.Add(i);
		    if (i != size - 1) {
		        Console.Write($"{i} "); 
		    } else {
		        Console.Write($"{i}\n"); 
		    }
		}
		return list;
	}
}

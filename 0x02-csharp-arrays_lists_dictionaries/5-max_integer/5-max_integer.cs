using System;

class List {
    public static int MaxInteger(List<int> myList) {
        if (myList.Length == 0) {
            Console.WriteLine("List is empty");
            return -1;
        }
        return (myList.OrderByDescending(x => x).First());
    }
}


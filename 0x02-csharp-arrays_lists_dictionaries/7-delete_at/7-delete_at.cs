﻿using System;
using System.Collections.Generic;


class List {
    public static List<int> DeleteAt(List<int> myList, int index) {
        if (index >= myList.Count) {
            Console.WriteLine("Index is out of range");
            return myList;
        }
        myList.Remove(index);
        return myList;
    }
}

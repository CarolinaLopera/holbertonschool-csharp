using System;
using System.Linq;
using System.Collections.Generic;


class List {
    public static int Sum(List<int> myList) {
        List<int> unique = myList.Distinct().ToList();
        return unique.Sum();
    }
}

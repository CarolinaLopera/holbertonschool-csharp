using System;
using System.Collections.Generic;


class List {
    public static List<bool> DivisibleBy2(List<int> myList) {
        List<bool> mod2 = new List<bool>();
        for (int i = 0; i < myList.Count; i++) {
            if (myList[i] % 2 == 0) {
                mod2.Add(true);
            } else {
                mod2.Add(false);
            }
        }
        return mod2;
    }
}

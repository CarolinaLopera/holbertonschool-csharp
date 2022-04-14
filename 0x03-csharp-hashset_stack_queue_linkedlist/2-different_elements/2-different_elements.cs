using System;
using System.Collections.Generic;

class List {
    public static List<int> DifferentElements(List<int> list1, List<int> list2) {
        List<int> different = new List<int>();

        foreach (int i in list2) {
            if (!list1.Contains(i)) {
                different.Add(i);
            }
        }
        foreach (int j in list1) {
            if (!list2.Contains(j)) {
                different.Add(j);
            }
        }
        different.Sort();
        return different;
    }
}

        // bool flag = false;
        // for (int i = 0; i < list1.Count; i++) {
        //         if (list1[i] != list2[j] && flag == false) {
        //             different.Add(list1[i]);
        //             flag = true;
        //         } else {
        //             flag = false;
        //             break;
        //         }
        //     for (int j = 0; j < list1.Count; j++) {
        //     }
        // }

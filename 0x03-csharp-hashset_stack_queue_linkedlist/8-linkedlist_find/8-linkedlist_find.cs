using System;
using System.Collections.Generic;

class LList {
    public static int FindNode(LinkedList<int> myLList, int value) {
        int count = 0;
        foreach (int i in myLList) {
            if (i == value) {
                return count;
            }
            count++;
        }

        return -1;
    }
}

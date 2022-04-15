using System;
using System.Collections.Generic;

class LList {
    public static int GetNode(LinkedList<int> myLList, int n) {
        LinkedListNode<int> index = myLList.First;
        for (int i = 0; index != null; i++) {
            if (i == n) {
                return index.Value;
            }
            index = index.Next;
        }

        return 0;
    }
}

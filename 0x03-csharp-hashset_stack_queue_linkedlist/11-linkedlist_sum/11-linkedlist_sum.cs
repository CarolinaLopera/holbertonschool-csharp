using System;
using System.Collections.Generic;


class LList {
    public static int Sum(LinkedList<int> myLList) {
        LinkedListNode<int> index = myLList.First;
        int result = 0;
        for (int i = 0; index != null; i++) {
            result += index.Value;
            index = index.Next;
        }

        return result;
    }
}

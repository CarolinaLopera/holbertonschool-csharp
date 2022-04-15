using System;
using System.Collections.Generic;

class LList {
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n) {
        LinkedListNode<int> node = myLList.First;
        while (node != null) {
            if (node.Value >= n) {
                myLList.AddBefore(node, n);
                return node.Next;
            }
            node = node.Next;
        }
        return null;
    }
}

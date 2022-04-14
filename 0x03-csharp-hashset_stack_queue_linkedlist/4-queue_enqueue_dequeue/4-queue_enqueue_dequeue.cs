using System;
using System.Collections.Generic;

class MyQueue {
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search) {
        Console.WriteLine("Number of items: {0}", aQueue.Count);
        
        if (aQueue.Count == 0) {
            Console.WriteLine("Queue is empty");
        } else {
            Console.WriteLine("First item: {0}", aQueue.Peek());
        }

        aQueue.Enqueue(newItem);
        if (aQueue.Contains(search)) {
            Console.WriteLine("Queue contains \"{0}\": True", search);
            bool flag = false;

            for (int i = aQueue.Count; i > 0; i ++) {
                aQueue.Dequeue();
                if (flag == true) {
                    break;
                } else if (aQueue.Peek() == search) {
                    flag = true;
                }
            }
        } else {
            Console.WriteLine("Queue contains \"{0}\": False", search);
        }
        return aQueue;
    }
}

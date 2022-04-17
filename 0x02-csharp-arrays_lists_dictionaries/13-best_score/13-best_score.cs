using System;
using System.Linq;
using System.Collections.Generic;


class Dictionary {
    public static string BestScore(Dictionary<string, int> myList) {
        int biggest = 0;
        string key = "";
        foreach (KeyValuePair<string, int> i in myList) {
            if (i.Value > biggest) {
                biggest = i.Value;
                key = i.Key;
            }
        }
        return key;
    }
}

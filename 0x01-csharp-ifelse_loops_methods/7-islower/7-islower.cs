using System;


class Character {
    public static bool IsLower(char c) {
        if (c >= 'a' && c <= 'z') {
            return true;
        } else {
            return false;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        char[] letters = { 'a', 'A', 'Q', 'h', '9', 'B', 'g'};
        int i;

        for (i = 0; i < letters.Length; i++)
        {
            if(Character.IsLower(letters[i]))
                Console.WriteLine("{0} is lowercase", letters[i]);
            else
                Console.WriteLine("{0} is uppercase", letters[i]);
        }
    }

} 

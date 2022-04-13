using System;

namespace _3_print_alphabt
{
    class Program
    {
        static void Main(string[] args)
        {
            char alphabet = 'a';

            for (int i = 0; i < 26; i++) {
                if (alphabet != 'e' && alphabet != 'q') {
                    Console.Write("{0}", alphabet);
                }
                alphabet++;
            }
        }
    }
}

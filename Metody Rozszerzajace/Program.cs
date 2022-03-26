using System;
using System.Collections.Generic;

namespace Metody_Rozszerzajace
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> enumerable = new string[] { "A", "B", "C" };
            enumerable.PrintLn();
            IEnumerable<int> enumerableint = new int[] { 1, 2, 3 };
            enumerableint.PrintLn();

        }
    }
}

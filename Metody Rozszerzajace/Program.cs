using System;
using System.Collections.Generic;

namespace Metody_Rozszerzajace
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 0, 1, 2, 3, 4 };
            Console.WriteLine(list.Dump());
        }
    }
}

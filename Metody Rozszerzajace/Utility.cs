using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody_Rozszerzajace
{
    public static class Utility
    {
        public static string WithoutVowels(this string str)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            foreach (var item in vowels)
            {
                str = str.Replace(item.ToString(), String.Empty);
            }
            return str;
        }

        public static bool IsNumeric(this string str) 
        {
            try
            {
                Int32.Parse(str);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static string Dump(this List<int> list) 
        {
            string str = "";
            foreach (var item in list)
            {
                str = str + item.ToString() + ", ";
            }
            // remove coma and space
            for (int i = 0; i < 2; i++)
            {
                str = str.Remove(str.Length - 1);
            }
            return str;
        }

        public static void PrintLn<T>(this IEnumerable<T> enumerable) 
        {
            IEnumerator<T> enumerator = enumerable.GetEnumerator();
            while (enumerator.MoveNext())
            {
                T s = enumerator.Current;
                Console.WriteLine(s);
            }
        }
    }
}

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
    }
}

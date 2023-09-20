using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace longest_substring_without_repeating_characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "bbbdabb";
            int temp1;
            int temp2 = 1;
            int max = (s.Length == 0) ? 0 : 1;
            for (var i = s.Length - 2; (i >= 0) & (temp2 + i > max); i--)
            {
                temp1 = 1;
                for (var j = i + 1; (j < Math.Min(s.Length, j + temp2 + 1)) & (s[i] != s[j % s.Length]); j++)
                {
                    temp1++;
                }
                if (temp1 > temp2)
                {
                    temp2++;
                    if (temp2 > max)
                    {
                        max = temp2;
                    }
                }
                else
                {
                    temp2 = temp1;
                }
            }
            Console.WriteLine(max);
        }
    }
}

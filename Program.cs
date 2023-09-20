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
            string s = "looabol";
            int n = s.Length;
            int res = 0;

            int[] lastIndex = new int[96];

            for (int j = 0; j < 96; j++)
            {
                lastIndex[j] = -1;
            }
            int i = 0;

            for (int j = 0; j < n; j++)
            {
                i = Math.Max(i, lastIndex[s[j] - 32] + 1);

                res = Math.Max(res, j - i + 1);

                lastIndex[s[j] - 32] = j;
            }
            Console.WriteLine(res);
        }
    }
}

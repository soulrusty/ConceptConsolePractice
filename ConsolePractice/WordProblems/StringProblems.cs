using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePractice.WordProblems
{
    static class StringProblems
    {
        public static int AddNumber(string inputnums)
        {
            int sum = 0;
            var number = inputnums.Split(',');
            foreach (string s in number)
            {
                sum = sum + Convert.ToInt32(s);
            }
            return sum;
        }

        public static int TimesAStringIsThere(string tofind, string fromstring)
        {
            var numofTimes = fromstring.Split(tofind, StringSplitOptions.RemoveEmptyEntries);
            return numofTimes.Length - 1;
        }

        public static string TimesACharIsThere(string fromstring)
        {
            Dictionary<char, int> dict = new();
            StringBuilder stringBuilder = new StringBuilder();

            foreach (char c in fromstring)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c] = dict[c] + 1;
                }
                else
                {
                    dict.Add(c, 1);
                }
            }
            foreach (var kvp in dict)
            {
                stringBuilder.Append(kvp.Key);
                stringBuilder.Append(kvp.Value);
            }

            return stringBuilder.ToString();
        }
    }
}

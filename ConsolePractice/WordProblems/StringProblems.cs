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

        public static string GetDuplicateString(string inputString)
        {
            StringBuilder duplicateCharacter = new();
            StringBuilder allDistinctCharacter = new();

            foreach (char c in inputString)
            {
                if(allDistinctCharacter.ToString().IndexOf(c) == -1)
                {
                    allDistinctCharacter.Append(c);
                }
                else
                {
                    duplicateCharacter.Append(c);
                }
            }
            return duplicateCharacter.ToString();
        }

        public static string GetValuesInReverse(string inputString)
        {
            //Approach 1
            string testValue = new string(inputString.Reverse().ToArray());

            //Approach 2
            StringBuilder sb = new();
            for(int i = inputString.Length - 1;i > -1;i--)
            {
                sb.Append(inputString[i]);
            }
            return sb.ToString();
        }

        public static bool CheckPalindrome(string inputString)
        {
            if(inputString == GetValuesInReverse(inputString))
                return true;
            return false;
        }

        public static string ReverseSentence(string inputString)
        {
            var intermediateArray = inputString.Split(" ");
            StringBuilder sb = new();
            for(int i =intermediateArray.Length-1;i>-1;i--)
            {
                sb.Append(intermediateArray[i]);
                if(i != 0)
                {
                    sb.Append(' ');
                }
            }
            return sb.ToString();
        }

        public static string ReverseEachWordOfTheSentence(string inputString)
        {
            var splitSentence = inputString.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            StringBuilder sb = new();
            foreach(string word in splitSentence)
            {
                sb.Append(GetValuesInReverse(word));
                sb.Append(' ');
            }
            return sb.ToString();
        }

        public static string GetTheWordCountInASentence(string inputString)
        {
            Dictionary<char, int> dictionary = new();
            foreach (char c in inputString)
            {
                if (char.IsWhiteSpace(c))
                    continue;
                if (dictionary.ContainsKey(c))
                {
                    dictionary[c]++;
                }
                else
                {
                    dictionary.Add(c, 1);
                }
            }

            StringBuilder sb = new();
            foreach(var v in dictionary)
            {
                sb.Append(v.Key +""+ v.Value);
            }

            return sb.ToString();
            
        }

        // Get the possible substring in a string  
        public static void GetPossibleSubstring(string inputString)
        {
            if (!string.IsNullOrEmpty(inputString))
            {
                for (int i = 1; i < inputString.Length; i++)
                {
                    for (int j = 0; j <= inputString.Length - i; j++)
                    {
                        Console.WriteLine(inputString.Substring(j, i));
                        //var getAllThreeCharacterSubstring = inputString.Substring(j, 3);
                    }
                }                
            }
        }

        public static void BinarySearchOnstring()
        {
            string[] arr = new string[]{ "Hi", "Guest", "I", "Mukesh", "Am" };
            Array.Sort(arr); // Am, Guest, Hi, I, Mukesh
            var index = Array.BinarySearch<string>(arr, "Hi");
            Console.WriteLine("The position of 'Hi' in array is " + index);
        }
    }
}

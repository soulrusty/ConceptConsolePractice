using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePractice.WordProblems
{
    public static class ArrayProblems
    {
        public static int CreateAddValueInArray()
        {
            int[] arrayList = new int[] {1,2,3,4,5,6,7,8,9,10,11,12};
            int sum = 0;
            //for(int i = arrayList.Length-1; i>-1 ;i-- )
            //{
            //    Console.WriteLine(arrayList[i]);
            //    sum = sum + arrayList[i];
            //}

            foreach(int val in arrayList)
            {                
                sum = sum + val;
            }
            return sum;
        }

        public static int[] FindDuplicateIntegersInArrayAndReturnInAscendingOrder(int input1, int[] input2)
        {
            Dictionary<int, int> result = new ();
            foreach(int i in input2)
            {
                if (result.ContainsKey(i))
                {
                    result[i]++;
                }
                else
                {
                    result.Add(i, 1);
                }
            }

            //Method 1
            //List<int> list = new List<int>();
            //foreach(var v in result)
            //{
            //    if (v.Value > 1)
            //    {
            //        list.Add(v.Key);
            //    }
            //}

            //if (list.Count > 0)
            //{
            //    list.Sort();
            //    return list.ToArray();
            //}          

            //Method 2
            //short using Linq

            if (result.Count > 0)
            {
                return result.Where(x => (x.Value > 1)).OrderBy(x => x.Key).Select(x => x.Key).ToArray();
            }
            else
            {
                return new int[] {-1 };
            }
        }
    }
}

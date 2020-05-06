using System;
using System.Collections.Generic;

namespace MajorityElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 2, 2, 1, 1, 1, 2, 2 };
            Console.WriteLine(MajorityElement(input));
            Console.ReadKey();
        }
        public static int MajorityElement(int[] nums)
        {
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            int compareLen = nums.Length / 2;
            foreach (var item in nums)
            {
                if (keyValuePairs.ContainsKey(item))
                {
                    keyValuePairs[item]++;
                }
                else
                {
                    keyValuePairs.Add(item, 1);
                }
            }

            foreach (var item in keyValuePairs)
            {
                if (item.Value > compareLen)
                {
                    return item.Key;
                }
            }

            return -1;
        }
    }
}

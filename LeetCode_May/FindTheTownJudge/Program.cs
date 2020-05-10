using System;
using System.Collections.Generic;
using System.Linq;

namespace FindTheTownJudge
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] input = new int[][]
          {
               // new int[] { 1, 2 },
          //      new int[] { 2, 1 },

              new int[] { 1, 3 },
              new int[] { 2, 3 },
              new int[] { 3, 1 },
              //new int[] { 2, 3 },
              //new int[] { 1, 4 },
              //new int[] { 4, 3 },
              //new int[] { 4, 1 },
          };

            var result = FindJudge(3, input);
            Console.WriteLine("Hello World!");
        }
        public static int FindJudge(int N, int[][] trust)
        {
            if (N == 1) return 1;
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            foreach (int[] pair in trust)
            {
                if (keyValuePairs.ContainsKey(pair[1]))
                {
                    keyValuePairs[pair[1]]++;
                }
                else
                {
                    keyValuePairs.Add(pair[1], 1);
                }

                if (keyValuePairs.ContainsKey(pair[0]))
                {
                    keyValuePairs[pair[0]]--;
                }
                else
                {
                    keyValuePairs.Add(pair[0], -1);
                }

            }

            foreach (var pair in keyValuePairs)
            {
                if (pair.Value >= N - 1)
                {
                    return pair.Key;
                }
            }

            return -1;

        }
    }
}

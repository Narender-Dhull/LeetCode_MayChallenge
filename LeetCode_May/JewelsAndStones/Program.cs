using System;

namespace JewelsAndStones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumJewelsInStones("aA", "aAAbbbb"));
            Console.WriteLine("Hello World!");
        }
        public static int NumJewelsInStones(string J, string S)
        {
            int sum = 0;
            char[] Jewels = J.ToCharArray();
            char[] JewelsIHave = S.ToCharArray();

            foreach (char c in Jewels)
            {
                foreach (char j in JewelsIHave)
                {
                    if (j.Equals(c))
                    {
                        sum++;
                    }
                }
            }
            return sum;
        }
    }
}

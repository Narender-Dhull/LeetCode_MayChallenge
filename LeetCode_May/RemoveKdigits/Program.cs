using System;
using System.Text;

namespace RemoveKdigits
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = "10200"; int k = 1;
            Console.WriteLine(removeKdigits(num, k));

            Console.WriteLine("Hello World!");
        }
        public static String removeKdigits(String num, int k)
        {
            if (num.Length == k) { return "0"; };

            StringBuilder sb = new StringBuilder(num);
            for (int j = 0, i = 0; j < k; j++)
            {
                while (i < sb.Length - 1 && sb[i] <= sb[i + 1])
                {
                    i++;
                }
                sb.Remove(i,1);
            }

            while (sb.Length > 1 && sb[0] == '0')
                sb.Remove(0, 1);

            if (sb.Length == 0)
            {
                return "0";
            }

            return sb.ToString();
        }
    }
}

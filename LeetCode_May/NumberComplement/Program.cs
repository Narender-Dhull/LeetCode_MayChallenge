using System;

namespace NumberComplement
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = FindComplement(5);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        public static int FindComplement(int num)
        {
            if (num == 1) { return 0; }
            if (num == 0) { return 1; }
            int remainder;
            int result = 0;
            int power = 0;
            while (num > 0)
            {
                remainder = num % 2;
                num /= 2;
                result = result + (Convert.ToInt32(Math.Pow(2, power)) * (1 - remainder));
                power++;
            }

            return result;
        }
    }
}

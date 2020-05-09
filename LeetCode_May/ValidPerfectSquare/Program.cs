using System;

namespace ValidPerfectSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPerfectSquare(14));
            Console.ReadKey();
        }
        public static bool IsPerfectSquare(int num)
        {
            return (Math.Sqrt(num) % 1) < 0.001;
        }
    }
}

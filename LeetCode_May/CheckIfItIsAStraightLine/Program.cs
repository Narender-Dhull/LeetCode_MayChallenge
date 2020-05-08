using System;

namespace CheckIfItIsAStraightLine
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] input = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 2, 3 },
                new int[] { 3, 4 },
                new int[] { 4, 5 },
                new int[] { 5, 6 },
                new int[] { 6, 7 }
            };

            bool res = CheckStraightLine(input);
            Console.WriteLine("Result : " + res);
            Console.ReadKey();
        }
        public static bool CheckStraightLine(int[][] coordinates)
        {
            int[] point1 = coordinates[1];
            int[] point2 = coordinates[0];

            float gSlope = slope(point1, point2);

            for (int i = 2; i < coordinates.Length; i++)
            {
                int[] p1 = coordinates[i];
                int[] p2 = coordinates[0];
                float slop = slope(p1, p2);
                if (gSlope != slop) return false;
            }

            return true;
        }

        public static float slope(int[] p1, int[] p2)
        {
            if ((p1[0] - p2[0]) == 0) return 0;
            return (float)(p2[1] - p1[1]) / (p2[0] - p1[0]);
        }

    }
}

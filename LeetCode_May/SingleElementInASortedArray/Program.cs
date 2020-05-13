using System;
using System.Diagnostics;

namespace SingleElementInASortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            int[] input = { 1, 1, 2, 3, 3, 4, 4, 8, 8 };
            Console.WriteLine(SingleNonDuplicate(input));
            Console.WriteLine(watch.ElapsedMilliseconds);
            watch.Stop();
            Console.ReadKey();
        }

        public static int SingleNonDuplicate(int[] nums)
        {
            int N = nums.Length;
            if (N == 1)
                return nums[0];

            int left = 0;
            int right = N - 1;
            int mid;


            while (left < right)
            {
                mid = left + ((right - left) >> 1);
                if (nums[mid] == nums[mid + 1])
                {
                    // from index mid to (N - 1) - if even then check left interval
                    if (((N - mid) & 1) == 0)
                        right = mid - 1;
                    else
                        left = mid + 1;
                }
                else if (nums[mid] == nums[mid - 1])
                {
                    // from index (mid - 1) to (N - 1) - if even then check left interval
                    if (((N - mid + 1) & 1) == 0)
                        right = mid - 2;
                    else
                        left = mid + 1;
                }
                else
                    return nums[mid];
            }

            return nums[left];
        }
    }
}

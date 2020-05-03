using System;

namespace FirstBadVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();
            int answer = _solution.FirstBadVersion(20);
            Console.WriteLine(answer.ToString());
            Console.WriteLine("Hello World!");
        }
        public class VersionControl
        {
            public bool IsBadVersion(int version)
            {
                return version == 9;
            }
        }
        public class Solution : VersionControl
        {
            public int FirstBadVersion(int n)
            {
                int left = 1;
                int right = n;
                while (left < right)
                {
                    int mid = left + (right - left) / 2;
                    if (IsBadVersion(mid))
                    {
                        right = mid;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                return left;
            }
        }
    }
}

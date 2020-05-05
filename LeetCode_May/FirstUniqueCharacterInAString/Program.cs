using System;
using System.Collections;
using System.Collections.Generic;

namespace FirstUniqueCharacterInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstUniqChar("eebbbooolaaaaa"));
            Console.ReadKey();
        }
        public static int FirstUniqChar(string s)
        {
            int[] count = new int[26];
            foreach (char c in s)
                count[c - 'a']++;
            for (int i = 0; i < s.Length; i++)
                if (count[s[i] - 'a'] == 1)
                    return i;
            return -1;
        }
    }

}

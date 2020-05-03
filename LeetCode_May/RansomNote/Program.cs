using System;
using System.Collections.Generic;

namespace RansomNote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CanConstruct("aa","aab"));
            Console.WriteLine("Hello World!");
        }
        public static bool CanConstruct(string ransomNote, string magazine)
        {
            List<char> ransomeLettersList = new List<char>(ransomNote);

            foreach (char c in magazine)
            {
                if (ransomeLettersList.Count == 0)
                {
                    return true;
                }

                int index = ransomeLettersList.IndexOf(c);
                if (index >= 0) { ransomeLettersList.RemoveAt(index); };
            }

            if (ransomeLettersList.Count > 0)
            {
                return false;
            }
            return true;
        }
    }
}

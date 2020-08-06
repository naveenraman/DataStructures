using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDataStructure.ArraysAndStrings
{
    //Given an integer n, find the closest integer (not including itself), which is a palindrome.
    //The 'closest' is defined as absolute difference minimized between two integers.
    public class FindTheClosestPalindrome
    {
        public string NearestPalindromic(string n)
        {
            int order = (int)Math.Pow(10, n.Length / 2);
            long input = long.Parse(n);
            long noChange = Mirror(input);
            long large = Mirror((input / order) * order + order + 1);
            long small = Mirror((input / order) * order - 1);
            if (noChange > input)
                large = (long)Math.Min(noChange, large);
            else if (noChange < input)
                small = (long)Math.Max(noChange, small);
            return ((input - small <= large - input) ? small : large).ToString();
        }

        private long Mirror(long input)
        {
            char[] charArray = input.ToString().ToCharArray();
            int i = 0;
            int j = charArray.Length - 1;
            while (i < j)
                charArray[j--] = charArray[i++];
            return long.Parse(new string(charArray));
        }
    }
}

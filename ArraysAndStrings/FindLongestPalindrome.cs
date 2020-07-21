using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDataStructure.ArraysAndStrings
{
    //Given a string s, find the longest palindromic substring in s. You may assume that the maximum length of s is 1000.
    //Time complexity : O(n^2). Since expanding a palindrome around its center could take O(n)O(n) time, the overall complexity is O(n^2).
    //Space complexity : O(1)

    public class FindLongestPalindrome
    {
        public string LongestPalindrome(string s)
        {
            var result = string.Empty;
            int resultLength = 0;
            if (s == null || s.Length < 1) return string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                var p1 = ExpandAroundCenter(s, i, i);
                if (p1.Length > resultLength)
                {
                    resultLength = p1.Length;
                    result = p1;
                }
                var p2 = ExpandAroundCenter(s, i, i + 1);
                if (p2.Length > resultLength)
                {
                    resultLength = p2.Length;
                    result = p2;
                }
            }
            return result;
        }
        private string ExpandAroundCenter(string s, int left, int right)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }
            return s.Substring(left + 1, right - left - 1);
        }
    }
}

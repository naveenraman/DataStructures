using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDataStructure.ArraysAndStrings
{
    public class FindAllAnagramsInAString
    {
        // Given a string s and a non-empty string p, find all the start indices of p's anagrams in s.
        // Strings consists of lowercase English letters only and the length of both strings s and p will not be larger than 20,100.
        // Time complexity: O(Ns + Np) since it's one pass along both strings.
        // Space complexity: O(1), because pCount and sCount contain 26 elements each.
        public List<int> FindAnagrams(string s, string p)
        {
            var result = new List<int>();
            if (string.IsNullOrWhiteSpace(s) || string.IsNullOrWhiteSpace(p))
                return result;
            int[] charCount = new int[26];
            foreach (var ch in p.ToCharArray())
                charCount[ch - 'a']++;
            int left = 0;
            int right = 0;
            int count = p.Length;
            while(right < s.Length)
            {
                if (charCount[s[right++] - 'a']-- >= 1)
                    count--;
                if (count == 0)
                    result.Add(left);
                if (right - left == p.Length && charCount[s[left++] - 'a']++ >= 0)
                    count++;
            }
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDataStructure.ArraysAndStrings
{
    public class MinimumInsertionStepsToMakeAStringPalindrome
    {
        public int MinInsertions(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return 0;
            int[,] array = new int[s.Length, s.Length];
            for (int i = 0; i < s.Length; i++)
                array[i, i] = 1;
            for (int ct = 2; ct <= s.Length; ct++)
            {
                for (int i = 0; i < s.Length - ct + 1; i++)
                {
                    int j = i + ct - 1;
                    if (s[i] == s[j])
                    {
                        if (ct == 2)
                            array[i, j] = 2;
                        else
                            array[i, j] = array[i + 1, j - 1] + 2;
                    }
                    else
                    {
                        array[i, j] = Math.Max(array[i, j - 1], array[i + 1, j]);
                    }
                }
            }
            return s.Length - array[0, s.Length - 1];
        }
    }
}

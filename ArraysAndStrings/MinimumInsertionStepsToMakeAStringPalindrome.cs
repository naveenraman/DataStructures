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
            if (s == null || s.Length == 0) return 0;
            int n = s.Length;
            int[,] array = new int[n, n];
            for (int i = 0; i < n; i++)
                array[i, i] = 1;
            for (int ct = 2; ct <= n; ct++)
            {
                for (int i = 0; i < n - ct + 1; i++)
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
            return n - array[0, n - 1];
        }
    }
}

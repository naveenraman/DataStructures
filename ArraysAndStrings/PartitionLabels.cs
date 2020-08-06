using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDataStructure.ArraysAndStrings
{
    //A string S of lowercase English letters is given. 
    //We want to partition this string into as many parts as possible so that each letter appears 
    //in at most one part, and return a list of integers representing the size of these parts.
    //Time Complexity: O(N), where NN is the length of S.
    //Space Complexity: O(1) to keep data structure last of not more than 26 characters.
    public class PartitionLabels
    {
        public List<int> PartitionLabel(string S)
        {
            var outputList = new List<int>();
            if (S.Length == 0) return outputList;
            var outputIndicies = new int[26];
            for (int i = 0; i < S.Length; i++)
                outputIndicies[S[i] - 'a'] = i;
            int end = 0;
            int start = 0;
            for (int i = 0; i < S.Length; i++)
            {
                end = Math.Max(end, outputIndicies[S[i] - 'a']);
                if (end == i)
                {
                    outputList.Add(end - start + 1);
                    start = end + 1;
                }
            }
            return outputList;
        }
    }
}

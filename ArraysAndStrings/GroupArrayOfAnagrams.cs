using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDataStructure.ArraysAndStrings
{
    //Given an array of strings, group anagrams together.
    //Time Complexity: O(NKlogK), where N is the length of strs, and K is the maximum length of a string in strs. The outer loop has complexity O(N) as we iterate through each string. Then, we sort each string in O(KlogK) time.
    //Space Complexity: O(NK), the total information content stored in ans.
    public class GroupArrayOfAnagrams
    {
        public List<List<string>> GroupAnagrams(string[] strs)
        {
            var dict = new Dictionary<string, List<string>>();
            foreach (var str in strs)
            {
                string tempStr = new string(str.OrderBy(c => c).ToArray());
                if (dict.ContainsKey(tempStr))
                    dict[tempStr].Add(str);
                else
                    dict.Add(tempStr, new List<string> { str });
            }
            return new List<List<string>>(dict.Values);
        }
    }
}

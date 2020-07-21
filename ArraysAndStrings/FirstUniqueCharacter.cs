using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDataStructure.ArraysAndStrings
{
    //First Unique Character in a String
    //Time complexity : O(N) since we go through the string of length N two times.
    //Space complexity : O(N) since we have to keep a hash map with N elements.
    public class FirstUniqueCharacter
    {
        public int FirstUniqChar(string s)
        {
            var dict = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                    dict[s[i]]++;
                else
                    dict.Add(s[i], 1);
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (dict[s[i]] == 1)
                    return i;
            }
            return -1;
        }
    }
}

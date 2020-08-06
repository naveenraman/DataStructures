using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDataStructure.ArraysAndStrings
{
    //Given a list of words (without duplicates), please write a program that returns all concatenated words in the given list of words.
    //A concatenated word is defined as a string that is comprised entirely of at least two shorter words in the given array.
    public class ConcatenatedWords
    {
        public IList<string> FindAllConcatenatedWordsInADict(string[] words)
        {
            var wordsSet = new HashSet<string>(words.Where(w => w != string.Empty));
            IList<string> result = new List<string>();
            var canForm = new Dictionary<string, bool>();
            foreach (var word in words)
            {
                if (CheckWord(canForm, wordsSet, word))
                    result.Add(word);
            }
            return result;
        }


        private bool CheckWord(Dictionary<string, bool> canForm, HashSet<string> set, string s)
        {
            if (canForm.ContainsKey(s))
                return canForm[s];
            for (int i = 1; i <= s.Length; i++)
            {
                string prefix = s.Substring(0, i);
                if (set.Contains(prefix))
                {
                    string postfix = s.Substring(i);
                    if (postfix.Length > 0 && (set.Contains(postfix) || CheckWord(canForm, set, postfix)))
                    {
                        canForm.Add(s, true);
                        return true;
                    }
                }
            }
            canForm.Add(s, false);
            return false;
        }
    }
}

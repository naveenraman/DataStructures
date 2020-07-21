using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDataStructure.ArraysAndStrings
{
    //Most Common Word
    //Given a paragraph and a list of banned words, return the most frequent word that is not in the list of banned words.
    //It is guaranteed there is at least one word that isn't banned, and that the answer is unique.
    //Words in the list of banned words are given in lowercase, and free of punctuation.Words in the paragraph are not case sensitive.
    //The answer is in lowercase.
    //Time Complexity: O(N+M)
    //Space Complexity: O(N+M)

    public class MostCommonWordOtherThanBanned
    {
        public string MostCommonWord(string paragraph, string[] banned)
        {
            var dict = new Dictionary<string, int>();
            foreach (var word in new string(paragraph.ToLower().Select(c => char.IsLetter(c) ? c : ' ').ToArray()).Split(' '))
            {
                if (!string.IsNullOrWhiteSpace(word) && !banned.Contains(word))
                {
                    if (dict.ContainsKey(word))
                        dict[word]++;
                    else
                        dict.Add(word, 1);
                }
            }
            return dict.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
        }
    }
}

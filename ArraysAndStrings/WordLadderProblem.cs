using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDataStructure.ArraysAndStrings
{
    //Given two words (beginWord and endWord), and a dictionary's word list, find the length of shortest transformation sequence from beginWord to endWord, such that:
    //Only one letter can be changed at a time.
    //Each transformed word must exist in the word list.
    //Time Complexity: O(M^2 × N), where MM is the length of each word and NN is the total number of words in the input word list.
    //Space Complexity: O(M^2 × N)
    public class WordLadderProblem
    {
        public int LadderLength(string beginWord, string endWord, List<string> wordList)
        {
            var wordl = new HashSet<String>();
            foreach (var w in wordList)
                wordl.Add(w);
            if (!wordl.Contains(endWord))
                return 0;
            int level = 1;
            var queue = new Queue<String>();
            queue.Enqueue(beginWord);
            while (queue.Count != 0)
            {
                int sizeofQ = queue.Count;
                for (int i = 0; i < sizeofQ; i++)
                {
                    char[] word = queue.Dequeue().ToCharArray();
                    for (int j = 0; j < beginWord.Length; j++)
                    {
                        char origchar = word[j];
                        for (char c = 'a'; c <= 'z'; c++)
                        {
                            word[j] = c;
                            var newWord = new string(word);
                            if (newWord.Equals(endWord))
                                return level + 1;
                            if (!wordl.Contains(newWord))
                                continue;
                            wordl.Remove(newWord);
                            queue.Enqueue(newWord);
                        }
                        word[j] = origchar;
                    }
                }
                level++;
            }
            return 0;
        }
    }
}

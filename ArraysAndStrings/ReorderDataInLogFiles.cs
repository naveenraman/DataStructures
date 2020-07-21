using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDataStructure.ArraysAndStrings
{
    public class ReorderDataInLogFiles
    {
        //You have an array of logs.Each log is a space delimited string of words.
        //For each log, the first word in each log is an alphanumeric identifier.Then, either:
        //Each word after the identifier will consist only of lowercase letters, or;
        //Each word after the identifier will consist only of digits.
        //We will call these two varieties of logs letter-logs and digit-logs.It is guaranteed that each log has at least one word after its identifier.
        //Reorder the logs so that all of the letter-logs come before any digit-log.
        //The letter-logs are ordered lexicographically ignoring identifier, with the identifier used in case of ties.  The digit-logs should be put in their original order.
        //Return the final order of the logs.
        //Time complexity : O(n Log n)
        //Space complexity : O(n). 
        public string[] ReorderLogFiles(string[] logs)
        {
            if (logs == null || logs.Length == 0)
                return logs;
            var letterLogs = new List<string>();
            var digitLogs = new List<string>();
            foreach (var log in logs)
            {
                if (char.IsDigit(log[log.IndexOf(' ') + 1]))
                    digitLogs.Add(log);
                else
                    letterLogs.Add(log);
            }
            letterLogs.Sort((log1, log2) =>
            {
                string subStr1 = log1.Substring(log1.IndexOf(' ') + 1);
                string subStr2 = log2.Substring(log2.IndexOf(' ') + 1);
                var result = subStr1.CompareTo(subStr2);
                if (result == 0)
                    result = log1.Substring(0, log1.IndexOf(' ')).CompareTo(log2.Substring(0, log2.IndexOf(' ')));
                return result;
            });
            letterLogs.AddRange(digitLogs);
            return letterLogs.ToArray();
        }
    }
}

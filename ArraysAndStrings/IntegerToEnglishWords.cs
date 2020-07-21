using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDataStructure.ArraysAndStrings
{
    //Convert a non-negative integer to its english words representation. Given input is guaranteed to be less than 231 - 1.
    //Time complexity : O(N). Intuitively the output is proportional to the number N of digits in the input.
    //Space complexity : O(1) since the output is just a string.
    public class IntegerToEnglishWords
    {
        string[] belowTen = new string[] { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        string[] belowTwenty = new string[] { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        string[] belowHundred = new string[] { "", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        public string NumberToWords(int num)
        {
            if (num == 0) return "Zero";
            return Helper(num);
        }
        private string Helper(int num)
        {
            string result = string.Empty;
            if (num < 10) result = belowTen[num];
            else if (num < 20) result = belowTwenty[num - 10];
            else if (num < 100) result = belowHundred[num / 10] + " " + Helper(num % 10);
            else if (num < 1000) result = Helper(num / 100) + " Hundred " + Helper(num % 100);
            else if (num < 1000000) result = Helper(num / 1000) + " Thousand " + Helper(num % 1000);
            else if (num < 1000000000) result = Helper(num / 1000000) + " Million " + Helper(num % 1000000);
            else result = Helper(num / 1000000000) + " Billion " + Helper(num % 1000000000);
            return result.Trim();
        }
    }
}

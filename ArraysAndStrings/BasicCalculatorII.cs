using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDataStructure.ArraysAndStrings
{
    public class BasicCalculatorII
    {
        public int Calculate(string s)
        {
            int result = 0;
            int sign = 1; //0 is m, 1 is d
            int md = -1; // 1 is +, -1 is -
            int operand = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char ch = s[i];
                if (Char.IsDigit(ch))
                {
                    int c = ch - '0';
                     while (++i < s.Length && char.IsDigit(s[i]))
                        c = 10 * c + s[i] - '0';
                     i--;
                    if(md == 0)
                        operand *= c;
                    else if(md == 1)
                        operand /=  c;
                    else
                        operand = c;
                }
                else if (ch == '/')
                    md = 1;
                else if (ch == '*')
                    md = 0;
                else if (ch == '+')
                { 
                    result += sign * operand;
                    sign = 1;
                }
                else if (ch == '-')
                {
                    result += sign * operand;
                    sign = -1;
                }
            }
            result += sign * operand;
            return result;
        }
    }
}

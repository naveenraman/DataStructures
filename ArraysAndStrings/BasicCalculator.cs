using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDataStructure.ArraysAndStrings
{
    //Implement a basic calculator to evaluate a simple expression string.
    //The expression string may contain open(and closing parentheses ), the plus + or minus sign -, non-negative integers and empty spaces.
    //Time Complexity: O(N), where N is the length of the string. 
    //The difference in time complexity between this approach and the previous one is that every character in this approach will get processed exactly once. 
    //However, in the previous approach, each character can potentially get processed twice, once when it's pushed onto the stack and once when it's popped for processing of the final result (or a subexpression). 
    //That's why this approach is faster.
    //Space Complexity: O(N), where N is the length of the string.
    public class BasicCalculator
    {
        public int Calculate(String s)
        {
            int operand = 0;
            int result = 0;
            int sign = 1;
            var stack = new Stack<int>();
            for(int i = 0; i < s.Length; i++)
            {
                char ch = s[i];
                if(Char.IsDigit(ch))
                {
                    operand = 10 * operand + (int)(ch - '0');
                }
                else if( ch == '+')
                {
                    result += sign * operand;
                    sign = 1;
                    operand = 0;
                }
                else if(ch == '-')
                {
                    result += sign * operand;
                    sign = -1;
                    operand = 0;
                }
                else if(ch == '(')
                {
                    stack.Push(result);
                    stack.Push(sign);
                    sign = 1;
                    result = 0;
                }
                else if(ch == ')')
                {
                    result += sign * operand;
                    result *= stack.Pop();
                    result += stack.Pop();
                    operand = 0;
                }
            }
            return result + (sign * operand);
        }
    }
}

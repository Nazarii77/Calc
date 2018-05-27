using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer
{
    public class Analyzer
    {
        private static int erposition = 0;
     
        public Parser parser = new Parser();

        public static string expression = "";

        public static bool ShowMessage = true;

        public static bool CheckCurrency()
        {
            int leftBracketCount = 0;
            int rightBracketCount = 0;
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    leftBracketCount++;
                }
                if (expression[i] == ')')
                {
                    rightBracketCount++;
                }
            }

            return (leftBracketCount == rightBracketCount);
        }

        public string convertToRPN (string expression)
        {
            Queue queue = new Queue();
            Stack stack = new Stack();
            //  1.While there are tokens to be read:
            //      2.Read a token
            //      3.If it's a number add it to queue
            //      4.If it's an operator
            //          5.While there's an operator on the top of the stack with greater precedence:
            //              6.Pop operators from the stack onto the output queue
            //          7.Push the current operator onto the stack
            //      8.If it's a left bracket push it onto the stack
            //      9.If it's a right bracket 
            //          10.While there's not a left bracket at the top of the stack:
            //              11.Pop operators from the stack onto the output queue.
            //          12.Pop the left bracket from the stack and discard it
            //  13.While there are operators on the stack, pop them to the queue
            foreach (char token in expression)
            {
                if (Char.IsNumber(token))
                    queue.Enqueue(token);
                if ("+-/*".Contains(token))
                {

                }
                    

            }
            return "";
        }

        public static string Format()
        {                
            
            return expression.Replace(" ", string.Empty);
        }



    }
}

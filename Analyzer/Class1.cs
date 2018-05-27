using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer
{
    public class Analyzer
    {
        private static int erposition = 0;

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

        public static string Format() {                
                return expression.Replace(" ",string.Empty);
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer
{
    class Error
    {
        public string message;
        public int error_position;
        public int errorCode;
        public Error (string message, int error_position, int errorCode)
        {
            this.message = message;
            this.error_position = error_position;
            this.errorCode = errorCode;
        }
    }

    class Validator
    {
        static string OPERATORS = "*-+/%^";

        static Error checkOperators(string expression)
        {
            bool isOperator = false;
            for (var i = 0; i < expression.Length; i++)
            {
                if (!Char.IsNumber(expression[i])
                    && !OPERATORS.Contains(expression[i])
                    && expression[i] != '('
                    && expression[i] != ')'
                    && expression[i] != ',')
                    return new Error("Невідомий оператор на " + i + " символі.", i, 2);

                if (isOperator == true && OPERATORS.Contains(expression[i]))
                    return new Error("Два  підряд  оператори  на " + i + " символі.", i, 4);
                isOperator = OPERATORS.Contains(expression[i]);

            }
            return new Error("", -1, 0);
        }

        public static Error getError(string expression)
        {
            var operatorError = checkOperators(expression);
            if (operatorError.error_position != -1) return operatorError;
            return new Error("", -1, 0);
        }
    }
}

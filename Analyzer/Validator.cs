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

        static Error checkIfOperatorsOneAfterAnother(string expression)
        {
            bool isOperator = false;
            for (var i = 0; i < expression.Length; i++)
            {
                if (isOperator == true && OPERATORS.Contains(expression[i]))
                    return new Error("Два  підряд  оператори  на " + i + " символі.", i, 4);
                isOperator = OPERATORS.Contains(expression[i]);

            }
            return new Error("", -1, 0);
        }

        public static Error getError(string expression)
        {
            var twoOperatorsNearEachOther = checkIfOperatorsOneAfterAnother(expression);
            if (twoOperatorsNearEachOther.error_position != -1) return twoOperatorsNearEachOther;
            return new Error("", -1, 0);
        }

        //public static string getErrorMessage(Error error)
        //{
        //    switch (error.errorCode)
        //    {
        //        case 4:
        //            return "Два  підряд  оператори  на  <i>  символі.";
        //    }
        //    return "";
        //}
    }
}

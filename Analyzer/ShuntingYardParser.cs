using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using CalcClass;
using System.Text.RegularExpressions;

namespace Analyzer
{
    
    public class Parser
    {
        static CalcClass.CalcClass CalcClass = new CalcClass.CalcClass();

        static bool isANumber(string n)
        {
            double retNum;
            bool isNumeric = double.TryParse(n, out retNum);
            return isNumeric;
        }

        public static Queue<string> getRPN(string expression)
        {
            string[] token = expression.Select(x => x.ToString()).ToArray();
            Stack<string> operatorStack = new Stack<string>();
            Queue<string> outputQueue = new Queue<string>();
            //Shunting Yard Algorithm Meat
            for (int i = 0; i < token.Length; i++)
            {
                if (isANumber(token[i]))
                {
                    outputQueue.Enqueue(token[i]);
                }
                else if (token[i].Equals("^"))
                {
                    operatorStack.Push(token[i]);
                }
                else if (operatorPrecedence(token[i]) != -1)
                {
                    while (operatorStack.Count != 0 && operatorPrecedence(operatorStack.Peek()) >= operatorPrecedence(token[i]))
                    {
                        outputQueue.Enqueue(operatorStack.Pop());
                    }
                    operatorStack.Push(token[i]);
                }
                else if (token[i].Equals("("))
                {
                    operatorStack.Push(token[i]);
                }
                else if (token[i].Equals(")"))
                {
                    while (!operatorStack.Peek().Equals("("))
                    {
                        outputQueue.Enqueue(operatorStack.Pop());
                    }
                    operatorStack.Pop();
                }
            }
            while (operatorStack.Count != 0)
                outputQueue.Enqueue(operatorStack.Pop());
  
            return outputQueue;
        }


        public static string calculate (string expression)
        {
            var error = Validator.getError(expression);
            if (error.errorCode == 0)
                return calculateRPN(getRPN(expression)).ToString();
            return error.message;
        }

        static double calculateRPN(Queue<string> inputQueue)
        {
            Stack<string> outputStack = new Stack<string>();

            while (inputQueue.Count != 0)
            {
                string s = inputQueue.Dequeue();
                if (isANumber(s))
                {
                    outputStack.Push(s);
                }
                else
                {
                    if (outputStack.Count < 2)
                    {
                        Console.WriteLine("error: insufficient values");
                        return -1.0;
                    }
                    else
                    {
                        string value1, value2;
                 
                         value1 = outputStack.First();
                         value2 = outputStack.First();
 

                        
                        double result = 0.0;
                        double a = Convert.ToDouble(value1);
                        double b = Convert.ToDouble(value2);
                        switch (s)
                        {
                            case "+":
                                result = CalcClass.Add(a, b);
                                break;
                            case "-":
                                result = CalcClass.Minus(a, b);
                                break;
                            case "*":
                                result = CalcClass.Multiply(a, b);
                                break;
                            case "/":
                                result = CalcClass.Div(a, b);
                                break;
                            case "%":
                                result = CalcClass.Mod(b, a);
                                break;
                            case "^":
                                result = CalcClass.Exp(a, b);
                                break;
                        }

                        string retVal = Convert.ToString(result);
                        outputStack.Push(retVal);

                    }

                }
            }

            if (outputStack.Count == 1)
            {
                double outcome = Convert.ToDouble(outputStack.Pop());
                return outcome;
            }
            else
            {
                Console.WriteLine("error in calculation");
                return -1.0;
            }
        }

        static int operatorPrecedence(string n)
        {
            int precedence = -1;
            char c = n[0];
            switch (c)
            {
                case '+':
                case '-':
                    precedence = 2;
                    break;
                case '*':
                case '/':
                case '%':
                    precedence = 3;
                    break;
                case '^':
                    precedence = 4;
                    break;

                default:
                    precedence = -1;
                    break;
            }
            return precedence;
        }
    }
}
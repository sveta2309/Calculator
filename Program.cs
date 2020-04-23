
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = EnterNumber1();
            char operation = EnterOperator();
            double b = EnterNumber2();
            Calculation c = new Calculation();


            switch (operation)
            {
                case '+':
                    PrintResult(c.Sum(a, b).ToString());
                    break;
                case '-':
                    PrintResult(c.Diff(a, b).ToString());
                    break;
                case '*':
                    PrintResult(c.Multiply(a, b).ToString());
                    break;
                case '/':
                    PrintResult(c.Division(a, b).ToString());
                    break;
                case '%':
                    PrintResult(c.RemainderOfDivision(a, b).ToString());
                    break;
            }
            Console.ReadLine();

        }

        static double EnterNumber1()
        {
            while (true)
            {
                Console.WriteLine("Enter first number:");
                double num1;
                if (double.TryParse(Console.ReadLine(), out num1))
                {
                    return num1;

                }
                else { continue; }


            }

        }
        static char EnterOperator()
        {
            while (true)
            {
                Console.WriteLine("Enter operator:");
                char oper = Console.ReadLine()[0];
                if (oper == '+' | oper == '-' | oper == '*' | oper == '/' | oper == '%')
                    return oper;

                else
                {
                    Console.WriteLine("Wrong input, try again!");
                    continue;
                }
            }
        }
        static double EnterNumber2()
        {
            while (true)
            {

                Console.WriteLine("Enter second number:");
                double num2;
                if (double.TryParse(Console.ReadLine(), out num2))
                {
                    return num2;
                }
                else { continue; }
            }
        }
        static void PrintResult(string result)
        {
            Console.WriteLine(result);
        }

    }
}

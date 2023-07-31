using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_19_ps_2
{
    public delegate T Operation<T>(T num1, T num2);

    public class Calculator
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two values:");

            Console.Write("Value 1: ");
            double value1 = double.Parse(Console.ReadLine());

            Console.Write("Value 2: ");
            double value2 = double.Parse(Console.ReadLine());

            Operation<double> addOperation = Calculator.Add;
            Operation<double> subtractOperation = Calculator.Subtract;
            Operation<double> multiplyOperation = Calculator.Multiply;
            Operation<double> divideOperation = Calculator.Divide;

            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            Console.Write("Your choice: ");
            int choice = int.Parse(Console.ReadLine());

            double result = 0;

            switch (choice)
            {
                case 1:
                    result = addOperation(value1, value2);
                    Console.WriteLine("Result: " + result);
                    break;
                case 2:
                    result = subtractOperation(value1, value2);
                    Console.WriteLine("Result: " + result);
                    break;
                case 3:
                    result = multiplyOperation(value1, value2);
                    Console.WriteLine("Result: " + result);
                    break;
                case 4:
                    result = divideOperation(value1, value2);
                    Console.WriteLine("Result: " + result);
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        }
    }
}
    


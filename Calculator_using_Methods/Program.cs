using System;
using System.Threading;

namespace Calculator_using_Methods
{
    class Program
    {
        // SUM METHOD
        static double Sum(double n, double m)
        {
            double sumResult = n + m;
            return sumResult;
        }
        // SUBTRACT METHOD
        static double Subtract(double n, double m)
        {
            double subResult = n - m;
            return subResult;
        }
        // DIVIDE METHOD
        static double Divide(double n, double m)
        {
            double divResult;
            if (m != 0)
            {
                divResult = n / m;
                return divResult;
            }
            else
            {
                Console.WriteLine("Can't divide by Zero\b\t");
                return double.NaN;
            }

        }
        // MULTIPLY METHOD
        static double Multiply(double n, double m)
        {
            double mulResult = n * m;
            return mulResult;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("***WELCOME TO THE C# CALCULATOR***\n");

            Console.WriteLine("Select the operation you want to perform!\n");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Division");
            Console.WriteLine("4. Multiplication");
            Console.WriteLine("5. Exit\n");

            Console.WriteLine("Enter your choice:");
            double choice = double.Parse(Console.ReadLine());
            if (choice == 5)
            {
                Console.WriteLine("You want to exit!");
                Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine("\nEnter first number: ");
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number: ");
                double num2 = double.Parse(Console.ReadLine());
                //int result=0;
                // int num2 = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("\nSum of the numbers: " + Sum(num1, num2));
                        break;
                    case 2:
                        Console.WriteLine("\nSubtraction of the numbers: " + Subtract(num1, num2));
                        break;
                    case 3:
                        Console.WriteLine("\nDivision of the numbers: " + Divide(num1, num2));
                        break;
                    case 4:
                        Console.WriteLine("\nMultiplication of the numbers: " + Multiply(num1, num2));
                        break;
                    default:
                        Console.WriteLine("\nInvalid Choice");
                        break;

                }
                Console.ReadKey();
            }
            
        }
    }
}

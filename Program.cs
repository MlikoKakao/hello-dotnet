using Microsoft.VisualBasic.FileIO

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            using (TextFieldParser parser = new TextFieldParser(@"data.csv"))
            {
                parser.TextFieldType























    }

















            static double Calculator()
            {
                while (true)
                {
                    Console.WriteLine("Enter first number: ");

                    double a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter operator (+ - * /): ");
                    string op = Console.ReadLine();

                    Console.WriteLine("Enter second number: ");
                    double b = Convert.ToDouble(Console.ReadLine());

                    double result = op switch
                    {
                        "+" => a + b,
                        "-" => a - b,
                        "*" => a * b,
                        "/" => b != 0 ? a / b : double.NaN,
                        "q" => false,
                        _ => double.NaN
                    };

                    Console.WriteLine($"Results: {result}");
                    Console.WriteLine();

                }
            }
        }

    }


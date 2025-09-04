using Microsoft.VisualBasic.FileIO;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            RealTestClass.PrintTest();
            Example.Test();
            Console.WriteLine("How many characters should your password have?");
            string scannedLength = Console.ReadLine();
            int length = 0;
            Int32.TryParse(scannedLength, out length);
            Console.WriteLine("Do you want special characters? Yes or no");
            string spec = "";
            spec = Console.ReadLine().ToLower();
            bool special = spec == "yes";
            PasswordGenerator(length, special);
        }



        static string PasswordGenerator(int length, bool special)
        {
            string characters = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM1234567890";
            string specialCharacters = "~!@#$%^&*-_=+|?/><";
            Random random = new Random();
            string password = "";
            int index = 0;

            if (special)
            {
                characters += specialCharacters;

                for (int i = 0; i < length; i++)
                {
                    index = random.Next(characters.Length);
                    password += characters[index];
                }
                Console.WriteLine("Password is: " + password);
                return password;

            }
            for (int i = 0; i < length; i++)
            {
                index = random.Next(characters.Length);
                password += characters[index];
            }
            Console.WriteLine("Password is: " + password);
            return password;

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
                    _ => double.NaN
                };

                Console.WriteLine($"Results: {result}");
                Console.WriteLine();

            }
        }

        static void ParserLINQ()
        {

            using (TextFieldParser parser = new TextFieldParser(@"data.csv"))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                List<double> payments = new List<double>();

                string paymentColumn = "";
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();


                    paymentColumn = fields[1];
                    if (Double.TryParse(paymentColumn, out double payment))
                    {
                        payments.Add(payment);
                    }
                    else
                    {
                        Console.WriteLine("Can't parse this line");
                    }
                }

                Console.WriteLine(payments.Sum());
                Console.WriteLine(payments.Average());
                float floatingNumber = 20.94f;
                floatingNumber += floatingNumber;
                Console.WriteLine(floatingNumber);
            }
        }
    }
}





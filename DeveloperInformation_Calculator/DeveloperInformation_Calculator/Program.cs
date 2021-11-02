using System;

namespace DeveloperInformation_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string info = developerinfo("What is your name?", "What class is this for?", "What's today's Date?");

            string answer;
            double val1 = 0;
            double val2 = 0;
            double sum = 0;
            do
            {

                Console.WriteLine($"Value of 1st number: {val1}");
                Console.WriteLine($"Value of 1st number: {val2}");
                Console.WriteLine("What type of calculation would you like to perform? Add? Subtract? Multiply? Divide?");
                string response = Console.ReadLine();
                if (response.ToLower() == "add")
                {
                    sum = Add(val1, val2);
                    Console.WriteLine($"The sum is {sum}");
                }
                else if (response.ToLower() == "subtract")
                {
                    sum = subtract(val1, val2);
                    Console.WriteLine($"The difference is {sum}");
                }
                else if (response.ToLower() == "multiply")
                {
                    sum = multiply(val1, val2);
                    Console.WriteLine($"The product is {sum}");
                }
                else if (response.ToLower() == "divide")
                {
                    sum = divide(val1, val2);
                    Console.WriteLine($"The quotient is {sum}");
                }

                Console.WriteLine("Would you like to perform a new calculation? Yes or No?");
                answer = Console.ReadLine();
                if (answer.ToLower() == "yes")
                {
                    Console.WriteLine("Would you like to use the answer in the next calculation? Yes or No?");
                    string dog = Console.ReadLine();
                    if (dog.ToLower() == "yes")
                    {
                        val1 = sum;
                        Console.WriteLine("Choose a second value to use.");
                        string newNumberAsString = Console.ReadLine();
                        double newNumber = Convert.ToDouble(newNumberAsString);
                        val2 = newNumber;
                    }
                    else
                    {

                    }
                }
                else
                {

                }

            } while (answer.ToLower() == "yes");

            Console.WriteLine("Thank you for using our calculator, goodbye");
            Console.WriteLine(info);
        }
        static double Add(double val1, double val2)
        {
            double sum = 0;
            sum = val1 + val2;
            return sum;
        }
        static double subtract(double val1, double val2)
        {
            double difference = val1 - val2;
            return difference;
        }
        static double multiply(double val1, double val2)
        {
            double product = val1 * val2;
            return product;
        }
        static double divide(double val1, double val2)
        {
            double quotient = val1 / val2;
            return quotient;
        }
        static string developerinfo(string name, string className, string date)
        {
            Console.WriteLine(name);
            string developersName = Console.ReadLine();

            Console.WriteLine(className);
            string developersclassName = Console.ReadLine();

            Console.WriteLine(date);
            string developersDate = Console.ReadLine();

            string developersinformation = $"{developersName} created the application for {developersclassName} on {developersDate}";

            return developersinformation;
        }
    }
}

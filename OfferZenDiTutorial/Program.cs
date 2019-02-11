using System;
using System.Linq;

namespace OfferZenDiTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = GetNumber("Enter the first number: > ");
            var number2 = GetNumber("Enter the second number: > ");
            var operand = GetOperand();
            var logger = new FileLogger();
            var calc = new Calculator(logger);
            var result = GetResult(calc, number1, number2, operand);
            Console.WriteLine($"{number1} {operand} {number2} = {result}");
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }

        private static float GetNumber(string message)
        {
            var isValid = false;
            while (!isValid)
            {
                Console.Write(message);
                var input = Console.ReadLine();
                isValid = float.TryParse(input, out var number);
                if (isValid)
                    return number;

                Console.WriteLine("Please enter a valid number. Press ^C to quit.");
            }

            return -1;
        }

        private static char GetOperand()
        {
            var isValid = false;
            while (!isValid)
            {
                Console.Write("Please type the operand (/*+-) > ");
                var input = Console.ReadKey();
                Console.WriteLine();
                var operand = input.KeyChar;
                if ("/*+-".Contains(operand))
                {
                    isValid = true;
                    return operand;
                }

                Console.WriteLine("Please enter a valid operand (/, *, +, or -). " +
                                  "Press ^C to quit.");
            }

            return ' ';
        }

        private static float GetResult(Calculator calc, float number1, float number2, char operand)
        {
            switch (operand)
            {
                case '/': return calc.Divide(number1, number2);
                case '*': return calc.Multiply(number1, number2);
                case '+': return calc.Add(number1, number2);
                case '-': return calc.Subtract(number1, number2);
                default:
                    // Should never happen if our previous validations are working
                    throw new InvalidOperationException($"Invalid operand passed: {operand}");
            }
        }
    }
}

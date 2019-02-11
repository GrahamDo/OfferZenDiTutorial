using System.IO;

namespace OfferZenDiTutorial
{
    public class Calculator
    {
        private const string FileName = "Calculator.log";

        public float Divide(float number1, float number2)
        {
            File.WriteAllText(FileName, $"Running {number1} / {number2}");
            return number1 / number2;
        }

        public float Multiply(float number1, float number2)
        {
            File.WriteAllText(FileName, $"Running {number1} * {number2}");
            return number1 * number2;
        }

        public float Add(float number1, float number2)
        {
            File.WriteAllText(FileName, $"Running {number1} + {number2}");
            return number1 + number2;
        }

        public float Subtract(float number1, float number2)
        {
            File.WriteAllText(FileName, $"Running {number1} - {number2}");
            return number1 - number2;
        }
    }
}

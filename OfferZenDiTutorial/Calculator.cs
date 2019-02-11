namespace OfferZenDiTutorial
{
    public class Calculator
    {
        private readonly FileLogger _logger;

        public Calculator()
        {
            _logger = new FileLogger();
        }

        public float Divide(float number1, float number2)
        {
            _logger.WriteLine($"Running {number1} / {number2}");
            return number1 / number2;
        }

        public float Multiply(float number1, float number2)
        {
            _logger.WriteLine($"Running {number1} * {number2}");
            return number1 * number2;
        }

        public float Add(float number1, float number2)
        {
            _logger.WriteLine($"Running {number1} + {number2}");
            return number1 + number2;
        }

        public float Subtract(float number1, float number2)
        {
            _logger.WriteLine($"Running {number1} - {number2}");
            return number1 - number2;
        }
    }
}

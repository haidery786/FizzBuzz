namespace FizzBuzz.Console.Services
{
    public class CalculatorService : ICalculatorService
    {
        public string Calculator(int inputNumber)
        {
            var result = string.Empty;

            if (inputNumber % 3 == 0 && inputNumber % 5 == 0)
            {
                result = "FizzBuzz";
                return result;
            }

            if (inputNumber % 3 == 0)
            {
                result = "Fizz";
                return result;
            }

            if (inputNumber % 5 == 0)
            {
                result = "Buzz";
                return result;
            }

            return inputNumber.ToString();
        }
    }
}

using FizzBuzz.Console.Services;

namespace FizzBuzz.Tests
{
    public class CalculatorService_Tests
    {
        private CalculatorService _calculatorService;

        [SetUp]
        public void Setup()
        {
            _calculatorService = new CalculatorService();
        }

        [Test]
        public void CalculatorService_Calculator_ReturnsFizzBuzz()
        {
            var expectedResult = "FizzBuzz";
            var result = _calculatorService.Calculator(15);
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void CalculatorService_Calculator_ReturnsFizz()
        {
            var expectedResult = "Fizz";
            var result = _calculatorService.Calculator(9);
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void CalculatorService_Calculator_ReturnsBuzz()
        {
            var expectedResult = "Buzz";
            var result = _calculatorService.Calculator(10);
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void CalculatorService_Calculator_ReturnsInputNumber()
        {
            var expectedResult = "8";
            var result = _calculatorService.Calculator(8);
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
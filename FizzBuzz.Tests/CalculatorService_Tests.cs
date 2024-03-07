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
    }
}
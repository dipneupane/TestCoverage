using TestCoverage.Services;

namespace TestCoverage.Test
{
    [TestClass]
    public class MathServiceTests
    {
        private MathService _mathService;

        [TestInitialize]
        public void Setup()
        {
            _mathService = new MathService();
        }

        [TestMethod]
        public void Add_ShouldReturnCorrectSum()
        {
            int result = _mathService.Add(5, 3);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            int result = _mathService.Subtract(10, 4);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Multiply_ShouldReturnCorrectProduct()
        {
            int result = _mathService.Multiply(6, 7);
            Assert.AreEqual(42, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_ByZero_ShouldThrowException()
        {
            _mathService.Divide(10, 0);
        }

        [TestMethod]
        public void Divide_ShouldReturnCorrectQuotient()
        {
            double result = _mathService.Divide(10, 2);
            Assert.AreEqual(5.0, result, 0.0001); // Allowing a small delta for floating-point precision
        }

        [TestMethod]
        public void Factorial_ShouldReturnCorrectValue()
        {
            int result = _mathService.Factorial(5);
            Assert.AreEqual(120, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Factorial_NegativeNumber_ShouldThrowException()
        {
            _mathService.Factorial(-3);
        }
    }
}
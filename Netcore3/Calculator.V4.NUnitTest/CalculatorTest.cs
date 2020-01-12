using NUnit.Framework;

namespace Calculator.V4.NUnitTest
{
    public class CalculatorTest
    {
        private BillCalculator _calculator;
        private RuleService _service;
        [SetUp]
        public void Setup()
        {
            _service = new RuleService();
            _calculator = new BillCalculator();
        }

        [Test]
        [TestCase(1, 500, "DIS10", 450)]
        [TestCase(1, 2000, "STARCARD", 1800)]
        [TestCase(2, 1500, "DIS10", 2250)]
        public void Calculate_Bill_Success(int numberOfCustomer, int pricePerPerson, string couponCode, double expect)
        {
            var discount = _service.GetDiscount(numberOfCustomer, numberOfCustomer * pricePerPerson, couponCode);

            var promotion = new Promotion(couponCode);

            var bill = new Bill(numberOfCustomer, pricePerPerson, promotion, discount);
            
            var actual = _calculator.Calculate(bill, discount);

            Assert.That(actual.Total, Is.EqualTo(expect), "Some useful error message");
        }

    }
}
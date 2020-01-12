using NUnit.Framework;

namespace Calculator.V4.NUnitTest
{
    public class DiscountRuleTest
    {
        private RuleService _service;
        [SetUp]
        public void Setup()
        {
            _service = new RuleService();
        }
        [Test]      
        [TestCase(1, 500, "NONE", 0)]
        [TestCase(2, 500, "NONE", 0)]
        [TestCase(3, 500, "NONE", 0)]
        [TestCase(4, 450, "NONE", 0)]
        public void GetDiscount_Nothing(int numberOfCustomer, int pricePerPerson, string couponCode, double expect)
        {
            var discount = _service.GetDiscount(numberOfCustomer, numberOfCustomer * pricePerPerson, couponCode);
            var actual = discount.Rate;
            Assert.That(actual, Is.EqualTo(expect), $"Expected discount rate {expect} percent.");
        }

        [Test]
        [TestCase(1, 500, "DIS10", 10)]
        [TestCase(1, 2000, "NONE", 10)]
        [TestCase(2, 1000, "NONE", 10)]
        public void GetDiscount_10Percent(int numberOfCustomer, int pricePerPerson, string couponCode, double expect)
        {
            var discount = _service.GetDiscount(numberOfCustomer, numberOfCustomer * pricePerPerson, couponCode);
            var actual = discount.Rate;
            Assert.That(actual, Is.EqualTo(expect), $"Expected discount rate {expect} percent.");
        }

        [Test]
        [TestCase(1, 2500, "STARCARD", 25)]
        [TestCase(4, 500, "STARCARD", 25)]
        [TestCase(3, 1000, "STARCARD", 25)]
        [TestCase(5, 500, "NONE", 25)]
        public void GetDiscount_25Percent(int numberOfCustomer, int pricePerPerson, string couponCode, double expect)
        {
            var discount = _service.GetDiscount(numberOfCustomer, numberOfCustomer * pricePerPerson, couponCode);
            var actual = discount.Rate;
            Assert.That(actual, Is.EqualTo(expect), $"Expected discount rate {expect} percent.");
        }

        [Test]
        [TestCase(2, 500, "STARCARD", 30)]
        [TestCase(2, 1000, "STARCARD", 30)]
        public void GetDiscount_30Percent(int numberOfCustomer, int pricePerPerson, string couponCode, double expect)
        {
            var discount = _service.GetDiscount(numberOfCustomer, numberOfCustomer * pricePerPerson, couponCode);
            var actual = discount.Rate;
            Assert.That(actual, Is.EqualTo(expect), $"Expected discount rate {expect} percent.");
        }
    }
}
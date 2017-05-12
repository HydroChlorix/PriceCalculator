using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace ConsoleApp2.Test
{

    [TestFixture]
    class TestCal
    {
        [Test]
        public void TestRule1_CASE_COUPON()
        {
            // arrange
            int numberOfCustomer = 1;
            int pricePerPerson = 500;
            double price = numberOfCustomer * pricePerPerson;
            string coupon = "DIS10";

            double expect = 450;

            CalculatorFactory fac = new CalculatorFactory();
            ICalculator cal = fac.GetCalculator(numberOfCustomer, price, coupon);

            double actual = cal.Calculate(price);

            Assert.AreEqual(expect, (price - actual));

        }

        [Test]
        public void TestRule1_CASE_PRICE_OVER_2000()
        {
            // arrange
            int numberOfCustomer = 4;
            int pricePerPerson = 500;
            double price = numberOfCustomer * pricePerPerson;
            string coupon = "";

            double expect = 1800;

            CalculatorFactory fac = new CalculatorFactory();
            ICalculator cal = fac.GetCalculator(numberOfCustomer, price, coupon);

            double actual = cal.Calculate(price);

            Assert.AreEqual(expect, (price - actual));

        }

        [Test]
        public void TestRule2_CASE_CUSTOMER_COME_2()
        {
            // arrange
            int numberOfCustomer = 2;
            int pricePerPerson = 500;
            double price = numberOfCustomer * pricePerPerson;
            string coupon = "STAR";

            double expect = 700;

            CalculatorFactory fac = new CalculatorFactory();
            ICalculator cal = fac.GetCalculator(numberOfCustomer, price, coupon);

            double actual = cal.Calculate(price);

            Assert.AreEqual(expect, (price - actual));

        }

        [Test]
        public void TestRule3_CASE_CUSTOMER_COME_4_PAY_3()
        {
            // arrange
            int numberOfCustomer = 4;
            int pricePerPerson = 500;
            double price = numberOfCustomer * pricePerPerson;
            string coupon = "STAR";

            double expect = 1500;

            CalculatorFactory fac = new CalculatorFactory();
            ICalculator cal = fac.GetCalculator(numberOfCustomer, price, coupon);

            double actual = cal.Calculate(price);

            Assert.AreEqual(expect, (price - actual));

        }
    }
}

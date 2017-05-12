using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace PriceCalculater.Test
{
    [TestFixture]
    class PromotionTest
    {
        [Test]
        public void TestDiscount10Percent()
        {
            // arrange 
            string coupon = "DIS10";
            Type expectType = typeof(PromotionDis10);

            // act
            PromotionFactory promoFactory = new PromotionFactory();
            IPromotion promo = promoFactory.GetPromotionByCode(coupon);
            Type actualType = promo.GetType();

            // assert
            Assert.AreEqual(expectType, actualType);
        }

        [Test]
        public void TestPromotionStarCard()
        {
            // arrange 
            string coupon = "STARCARD";
            Type expectType = typeof(PromotionStarCard);

            // act
            PromotionFactory promoFactory = new PromotionFactory();
            IPromotion promo = promoFactory.GetPromotionByCode(coupon);
            Type actualType = promo.GetType();

            // assert
            Assert.AreEqual(expectType, actualType);
        }

        [Test]
        public void TestPromotionDefault()
        {
            // arrange 
            string coupon = "NONE";
            Type expectType = typeof(DefaultPromotion);

            // act
            PromotionFactory promoFactory = new PromotionFactory();
            IPromotion promo = promoFactory.GetPromotionByCode(coupon);
            Type actualType = promo.GetType();

            // assert
            Assert.AreEqual(expectType, actualType);
        }

        [Test]
        public void TestPromotionNotImplemented()
        {
            // arrange 
            string coupon = "";
            var typeExpect = Throws.TypeOf<NotImplementedException>();

            // act
            PromotionFactory promoFactory = new PromotionFactory();
            ActualValueDelegate<object> testDelegate = () => promoFactory.GetPromotionByCode(coupon);

            // assert
            Assert.That(testDelegate, typeExpect);
        }
    }
}

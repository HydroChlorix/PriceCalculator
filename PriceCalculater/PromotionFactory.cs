using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculater
{
    interface IPromotionFactory
    {
        IPromotion GetPromotionByCode(string promoCode);
    }
    class PromotionFactory : IPromotionFactory
    {
        public IPromotion GetPromotionByCode(string promoCode)
        {
            IPromotion promo;

            switch (promoCode)
            {
                case "DIS10":
                    promo = new PromotionDis10();
                    break;
                case "STARCARD":
                    promo = new PromotionStarCard();
                    break;
                case "NONE":
                    promo = new DefaultPromotion();
                    break;
                default:
                    throw new NotImplementedException();
            }

            return promo;
        }
    }
}

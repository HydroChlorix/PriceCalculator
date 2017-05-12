using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculater
{
    public interface IPromotion
    {
        int GetRule(int customer, int price);
    }
    class BasePromotion
    {
        private string _PromotionCode;
        public BasePromotion(string promotionCode)
        {
            _PromotionCode = promotionCode;
        }

    }
    class PromotionDis10 : IPromotion
    {
        public int GetRule(int customer, int price)
        {
            throw new NotImplementedException();
        }
    }

    class PromotionStarCard : IPromotion
    {
        public int GetRule(int customer, int price)
        {
            throw new NotImplementedException();
        }
    }

    class DefaultPromotion : IPromotion
    {
        public int GetRule(int customer, int price)
        {
            throw new NotImplementedException();
        }
    }

}

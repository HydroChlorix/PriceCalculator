using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculater
{
    interface IDiscountFactory
    {
        int GetDiscountPercent(Discounts discount);
    }
    class DiscountFactory : IDiscountFactory
    {
        public int GetDiscountPercent(Discounts discount)
        {
            int discountPrecent = 0;
            switch (discount)
            {
                case Discounts.Discount_10_Percent:
                    discountPrecent = 10;
                    break;
                case Discounts.Discount_25_Percent:
                    discountPrecent = 25;
                    break;
                case Discounts.Discount_30_Percent:
                    discountPrecent = 30;
                    break;
                default:
                    break;
            }
            return discountPrecent;
        }
    }
}

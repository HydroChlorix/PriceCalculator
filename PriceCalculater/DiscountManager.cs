using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculater
{
    class DiscountManager
    {
        private IPromotion promo;
        private int customer;
        private int price;

        public DiscountManager(int customer, int price, IPromotion promo)
        {
            this.customer = customer;
            this.price = price;
            this.promo = promo;
        }

        internal double ApplyDiscount()
        {
            var priceBeforeDiscount = (customer * price);

            var discountValue = 0;


          //Rule r =  promo.GetRule(this.customer, this.price);
            //promo.GetRule(customer, price)

            //var discountPercent = promo.GetDiscountPercent();

            //if (discountPercent > 0)
            //{
            //    discountValue = (priceBeforeDiscount * discountPercent / 100);
            //}

            return priceBeforeDiscount - discountValue;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculater
{
    class BillManager
    {
        private IPromotionFactory _PromotionFactory;
        private IDiscountFactory _DiscountFactory;
        public BillManager(IPromotionFactory factory, IDiscountFactory discount)
        {
            _PromotionFactory = factory;
            _DiscountFactory = discount;
        }

        public Bill CreateBill()
        {
            var code = "DIS10";
            var price = 2000;
            var customer = 2;


            IPromotion promo = _PromotionFactory.GetPromotionByCode(code);

            DiscountManager discMgr = new DiscountManager(customer, price, promo);

            double discountValue = discMgr.ApplyDiscount();


            //var discountPercent = promo.GetDiscountPercent();
            //var discountPercent = _DiscountFactory.GetDiscountPercent();




            //var rules = MatchRule(customer, price, code);

            //var discount = GetDiscount(customer, price, code);

            return new Bill(customer, price, 0, 0);
        }



        //private decimal GetDiscount(int customer, int price, string code)
        //{
        //    decimal discount = 0;

        //    if (code == "DIS10" || price >= 2000)
        //    {
        //        discount = 10;
        //    }
        //    else if (code == "STARCARD")
        //    {
        //        if (customer == 2)
        //        {
        //            discount = 30;
        //        }
        //        else if (customer == 4)
        //        {
        //            try
        //            {
        //                discount = 3 / customer;
        //            }
        //            catch (Exception)
        //            {
        //                throw;
        //            }
        //        }
        //    }
        //    else if (price >= 2500)
        //    {
        //        discount = 25;
        //    }

        //    return discount;
        //}

    }
}

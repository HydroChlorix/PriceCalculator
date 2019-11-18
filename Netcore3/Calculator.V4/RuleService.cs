using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator.V4
{
    public interface IRuleService
    {

    }

    public class RuleService : IRuleService
    {
        //private readonly List<Rule> _list;
        public RuleService()
        {
            //this._list = new List<Rule>()
            //{
            //    new Rule() { Code = "NONE" , DiscountRate = 0  },
            //    new Rule() { Code = "DIS10", DiscountRate = 10 },
            //    new Rule() {},
            //    new Rule() { Code = "STARCARD" },
            //};
        }
        public Discount GetDiscount(int numberOfCustomer, double price, string couponCode)
        {
            List<Discount> discounts = new List<Discount>();
            if (couponCode == "DIS10" || price >= 2000)
            {
                discounts.Add(new Discount(10));
            }

            if (couponCode == "STARCARD")
            {
                if (numberOfCustomer == 2)
                {
                    discounts.Add(new Discount(30));
                }
                else if (numberOfCustomer == 4)
                {
                    discounts.Add(new Discount(25));
                }
            }

            if (price >= 2500)
            {
                return new Discount(25);
            }

            return discounts.Any() ? discounts.OrderByDescending(r => r.Rate).FirstOrDefault() : new Discount(0);
        }
    }
}

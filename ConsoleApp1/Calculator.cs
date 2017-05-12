using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface ICalculator
    {
        int ApplyDiscount(int price);
    }
    public class Calculator : ICalculator
    {
        private Promotion promo;

        public Calculator(Promotion promo)
        {
            this.promo = promo;
        }

        public int ApplyDiscount(int price)
        {

            foreach (var item in promo.Rules)
            {

                if (item.GetType() == typeof(RuleCode))
                {

                }
                else if (item.GetType() == typeof(RuleCustomer))
                {

                }
                else if (item.GetType() == typeof(RulePrice))
                {

                }
            }

            return 0;
        }
    }
}

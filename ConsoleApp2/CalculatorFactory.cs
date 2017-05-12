using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    public class CalculatorFactory
    {
        internal ICalculator GetCalculator(int numberOfCustomer, double price, string coupon)
        {
            ICalculator result;

            List<double> list = new List<double>();

            if (coupon == "DIS10")
            {
                list.Add(Constants.DISCOUNT_FOR_10);
            }

            if (coupon == "STAR" && numberOfCustomer == 2)
            {
                list.Add(Constants.DISCOUNT_FOR_30);
            }

            if (coupon == "STAR" && numberOfCustomer == 4)
            {
                list.Add(Constants.DISCOUNT_FOR_25);
            }

            if (coupon == "NONE")
            {
                result = new DefaultCaltulator();
            }

            if (price >= 2000)
            {
                list.Add(Constants.DISCOUNT_FOR_10);
            }

            if (price >= 2500)
            {
                list.Add(Constants.DISCOUNT_FOR_25);
            }

            var maxDiscountPercent = list.Max(x => x);

            switch (maxDiscountPercent)
            {
                case Constants.DISCOUNT_FOR_10:
                    result = new Calculator10();
                    break;
                case Constants.DISCOUNT_FOR_25:
                    result = new Calculator25();
                    break;
                case Constants.DISCOUNT_FOR_30:
                    result = new Calculator30();
                    break;
                default:
                    result = new DefaultCaltulator();
                    break;
            }

            return result;
        }
    }
}

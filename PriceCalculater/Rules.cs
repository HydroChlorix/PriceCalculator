using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculater
{
    public interface IRule
    {
        int GetDiscount();
    }

    abstract class BaseRule
    {
        protected void Validate(int customer, int price, string code)
        {
            if (customer == 0 || price == 0)
            {
                throw new ArgumentException();
            }
        }
    }

    class Rule : BaseRule, IRule
    {
        private int _conditionCustomer;
        private int _conditionPrice;
        private int _percent;
        public Rule(int customer, int price, int percent)
        {
            _conditionCustomer = customer;
            _conditionPrice = price;
            _percent = percent;
        }
        public int GetDiscount()
        {
            return _percent;
        }
    }
    //class Rule1 : BaseRule, IRule
    //{
    //    public int GetDiscount(int customer, int price, string code)
    //    {
    //        base.Validate(customer, price, code);

    //        return (code == "DIS10" || price >= 2000) ? 10 : 0;
    //    }
    //}
    //class Rule2 : BaseRule, IRule
    //{
    //    public int GetDiscount(int customer, int price, string code)
    //    {
    //        base.Validate(customer, price, code);

    //        return (code == "STARCARD" && customer == 2) ? 30 : 0;
    //    }
    //}
    //class Rule3 : BaseRule, IRule
    //{
    //    public int GetDiscount(int customer, int price, string code)
    //    {
    //        base.Validate(customer, price, code);

    //        return (code == "STARCARD" && customer == 4) ? (3 / customer) : 0;
    //    }
    //}
    //class Rule4 : BaseRule, IRule
    //{
    //    public int GetDiscount(int customer, int price, string code)
    //    {
    //        base.Validate(customer, price, code);

    //        return (price >= 2500) ? 25 : 0;
    //    }
    //}


}

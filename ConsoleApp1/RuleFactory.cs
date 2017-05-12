using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class RuleFactory
    {
        public IRule GetRule(RuleType type, int value)
        {
            IRule rule;

            switch (type)
            {
                case RuleType.Customer:
                    rule = new RuleCustomer(value);
                    break;
                case RuleType.Price:
                    rule = new RulePrice(value);
                    break;
                default:
                    throw new ArgumentException();
            }

            return rule;
        }
        public IRule GetRule(RuleType type, string value)
        {
            IRule rule;

            switch (type)
            {
                case RuleType.Code:
                    rule = new RuleCode(value);
                    break;
                default:
                    throw new ArgumentException();
            }

            return rule;
        }
    }
}

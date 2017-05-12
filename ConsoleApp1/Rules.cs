using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum RuleType
    {
        Price,
        Customer,
        Code
    }

    public interface IRule { }

    public class RuleCode : IRule
    {
        public string value;
        public RuleCode(string value)
        {
            this.value = value;
        }
    }

    public class RuleCustomer : IRule
    {
        public int value;
        public RuleCustomer(int value)
        {
            this.value = value;
        }
    }

    public class RulePrice : IRule
    {
        public int value;
        public RulePrice(int value)
        {
            this.value = value;
        }
    }

}

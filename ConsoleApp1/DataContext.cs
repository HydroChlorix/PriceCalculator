using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IContext
    {

    }
    public class DataContext : IContext
    {
        public List<Promotion> Promotions { get; private set; }

        public DataContext()
        {
            InitialContext();
        }

        private void InitialContext()
        {
            if (Promotions == null)
            {
                Promotions = new List<Promotion>();

                var ruleFactory = new RuleFactory();

                var promotionDefault = new Promotion("NONE");
                Promotions.Add(promotionDefault);

                var promotion1 = new Promotion("DISCOUNT10");
                promotion1.Rules = new List<IRule>();
                promotion1.Rules.Add(ruleFactory.GetRule(RuleType.Code, promotion1.ToString()));
                promotion1.Rules.Add(ruleFactory.GetRule(RuleType.Price, 2000));

                Promotions.Add(promotion1);

                var promotion2 = new Promotion("STARCARD");
                promotion2.Rules = new List<IRule>();
                promotion2.Rules.Add(ruleFactory.GetRule(RuleType.Customer, 2));
                promotion2.Rules.Add(ruleFactory.GetRule(RuleType.Customer, 4));

                Promotions.Add(promotion2);
            }
        }
    }
}

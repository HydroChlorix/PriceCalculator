using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PromotionManager
    {
        private List<Promotion> promotions;

        public PromotionManager(List<Promotion> promotions)
        {
            this.promotions = promotions;
        }

        public Promotion GetPromotionByCode(string Code)
        {
            return promotions.Where(x => x.Name == Code).FirstOrDefault();
        }
    }
}

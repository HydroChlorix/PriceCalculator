using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculater
{
    public class Bill
    {
        private int _NoOfCustomer;
        private int _PricePerPerson;
        private double _Discount { get; set; }
        private double _Total { get; set; }

        public Bill(int NoOfCustomer, int PricePerPerson, double Discount, double Total)
        {
            _NoOfCustomer = NoOfCustomer;
            _PricePerPerson = PricePerPerson;

            _Discount = Discount;
            _Total = Total;
        }
    }
}

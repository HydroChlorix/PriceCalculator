using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Bill
    {
        private int _NoOfCustomer;
        private int _PricePerPerson;
        private Promotion promo;

        //private double _Discount { get; set; }
        //private double _Total { get; set; }

        public Bill()
        {

        }
        public Bill(int NoOfCustomer, int PricePerPerson)
        {
            _NoOfCustomer = NoOfCustomer;
            _PricePerPerson = PricePerPerson;

            //_Discount = Discount;
            //_Total = Total;
        }

        public Bill(int NoOfCustomer, int PricePerPerson, Promotion promo) : this(NoOfCustomer, PricePerPerson)
        {
            this.promo = promo;
        }
    }

    public class BillManager
    {
        public Bill CreateBill()
        {
            return new Bill();
        }

        internal Bill CreateBill(int noOfCustomer, int price, Promotion promo)
        {


        

            throw new NotImplementedException();
        }
    }
}

using System;

namespace Calculator.V4
{
    public class Bill
    {
        public int NumberOfCustomer { get; }
        public int PricePerPerson { get; }
        public Promotion PromoCode { get; }
        public Discount Discount { get; }
        public double Total { get; set; }
        int BillNo { get { return new Random().Next(); } }
        public Bill(int numberOfCustomer, int pricePerPerson, Promotion promoCode, Discount discount)
        {
            NumberOfCustomer = numberOfCustomer;
            PricePerPerson = pricePerPerson;
            PromoCode = promoCode;
            Discount = discount;
        }
        public void UpdateTotal(double total)
        {
            Total = total;
        }
        public override string ToString()
        {
            return $"Bill No {BillNo} Total {Total}";
        }

    }

}

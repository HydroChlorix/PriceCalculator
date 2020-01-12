using System;

namespace Calculator.V4
{
    public class BillCalculator : ICalculator
    {
        protected Func<int, int, double, double> CalculatePrice = (int numberOfCustomer, int pricePerPerson, double rate) => numberOfCustomer * pricePerPerson * rate;
        public Bill Calculate(Bill bill, Discount discount)
        {
            if (discount == null || bill == null)
                throw new ArgumentNullException();

            if (bill.NumberOfCustomer == 0 || bill.PricePerPerson == 0)
                throw new ArgumentException();

            var discountRate = discount.Rate == 0 ? 1 : 1 - (discount.Rate / 100);

            var calculateResult = CalculatePrice(bill.NumberOfCustomer, bill.PricePerPerson, discountRate);
            bill.UpdateTotal(calculateResult);

            return bill;
        }
        //public double Calculate(int numberOfCustomer, int pricePerPerson, Discount discount)
        //{
        //    if (discount == null)
        //        throw new ArgumentNullException();
        //    if (numberOfCustomer == 0 || pricePerPerson == 0)
        //        throw new ArgumentException();

        //    var discountRate = discount.Rate == 0 ? 1 : discount.Rate;
        //    return calculate(numberOfCustomer, pricePerPerson, discountRate);
        //}
    }

}

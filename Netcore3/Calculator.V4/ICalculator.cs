namespace Calculator.V4
{
    interface ICalculator
    {
        //double Calculate(int numberOfCustomer, int pricePerPerson, Discount promotion);
        Bill Calculate(Bill bill, Discount discount);
    }

}

namespace Calculator.V4
{
    public class Rule
    {
        public string Code { get; set; }
        public int NumberOfCustomer { get; set; }
        public float Price { get; set; }
        public int DiscountRate { get; set; }
    }

    public class Discount
    {     
        public Discount(double rate)
        {
            this.Rate = rate;
        }
        public double Rate { get; set; }
    }

}

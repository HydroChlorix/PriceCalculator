using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public interface ICalculator
    {
        double Calculate(double price);
    }

    public static class Constants
    {
        public const double DISCOUNT_FOR_10 = 10;
        public const double DISCOUNT_FOR_25 = 25;
        public const double DISCOUNT_FOR_30 = 30;
    }

    public class DefaultCaltulator : ICalculator
    {
        public double Calculate(double price)
        {
            return price;
        }
    }

    public class Calculator10 : ICalculator
    {
        public double Percent = Constants.DISCOUNT_FOR_10;
        public double Calculate(double price)
        {
            return price * (Percent / 100);
        }
    }

    public class Calculator25 : ICalculator
    {
        public double Percent = Constants.DISCOUNT_FOR_25;
        public double Calculate(double price)
        {
            return price * (Percent / 100);
        }
    }

    public class Calculator30 : ICalculator
    {
        public double Percent = Constants.DISCOUNT_FOR_30;
        public double Calculate(double price)
        {
            return price * (Percent / 100);
        }
    }

    //public class Calculator
    //{
    //    public double Value { get; set; }
    //    public Calculator(double Value)
    //    {
    //        this.Value = Value;
    //    }
    //}
}

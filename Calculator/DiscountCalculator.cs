namespace Calculator
{
    public class DiscountCalculator
    {
        public decimal Calculate(decimal value)
        {
            if (value >= 50000)
            {
                return 0.15m;
            }

            if (value >= 10000)
            {
                return 0.1m;
            }

            if (value >= 7000)
            {
                return 0.07m;
            }

            if (value >= 5000)
            {
                return 0.05m;
            }

            if (value >= 1000)
            {
                return 0.03m;
            }

            return 0;
        }
    }
}
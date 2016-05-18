using System;

namespace Calculator
{
    public class StateTaxRepository
    {
        public decimal GetStateTax(string state)
        {
            switch (state)
            {
                case "UT":
                    return 0.0685m;
                case "NV":
                    return 0.08m;
                case "TX":
                    return 0.0625m;
                case "AL":
                    return 0.04m;
                case "CA":
                    return 0.0825m;
            }

            throw new Exception("Unknown state");
        }
    }
}
using System;

namespace Calculator
{
    public class CalculatorInputValidator
    {
        public void Validate(CalculatorInput input)
        {
            if (input.ItemCount < 0)
            {
                throw new Exception("Negative item count");
            }
        }
    }
}
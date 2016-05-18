namespace Calculator
{
    public class Calculator
    {
        public CalculaionResult Calculate(CalculatorInput input)
        {
            var value = input.Price * input.ItemCount;

            var discount = new DiscountCalculator().Calculate(value);
            var discountValue = value * discount;

            value -= discountValue;

            var stateTax = new StateTaxRepository().GetStateTax(input.State);
            var taxValue = value * stateTax;

            value += taxValue;

            return new CalculaionResult
            {
                Value = value,
                State = input.State,
                TaxValue = taxValue,
                DiscountValue = discountValue
            };
        }
    }
}
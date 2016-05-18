using System;

namespace Calculator
{
    public class CalculationResultPrinter
    {
        public void Print(CalculaionResult result, CalculatorInput input)
        {
            Console.WriteLine("Result:");
            Console.WriteLine($"{result.Value} ({input.ItemCount} * {input.Price} - {result.DiscountValue} discount + {result.TaxValue} {result.State} state tax)");
        }
    }
}
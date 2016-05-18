using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator v1");

            try
            {
                var input = new CalculationInputReader().Read();
                new CalculatorInputValidator().Validate(input);

                var result = new Calculator().Calculate(input);
                new CalculationResultPrinter().Print(result, input);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
           
            Console.ReadLine();
        }
    }
}

using System;

namespace Calculator
{
    public class CalculationInputReader
    {
        public CalculatorInput Read()
        {
            var input = new CalculatorInput();

            Console.WriteLine("Please enter price:");
            input.Price = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Please enter item count:");
            input.ItemCount = decimal.Parse(Console.ReadLine());
            
            Console.WriteLine("Please enter state:");
            input.State = Console.ReadLine();

            return input;
        }
    }
}
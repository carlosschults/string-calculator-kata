using System;

namespace carlosschults.StringCalculatorKata
{
    public class StringCalculator
    {
        public static int Add(string numbers)
        {
            var parts = numbers.Split(',');
            var result = 0;
            
            foreach (var part in parts)
            {
                int.TryParse(part, out int number);
                if (number <= 1000)
                    result += number;
            }

            return result;
        }
    }
}
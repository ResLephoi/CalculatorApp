using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            var delimiters = new List<string> { "\n" , "," };

            if (numbers.StartsWith("//"))
            {
                var delimiterEndIndex = numbers.IndexOf('\n');
                var delimiter = numbers.Substring(2, delimiterEndIndex - 2);
                delimiters.Add(delimiter);
                numbers = numbers.Substring(delimiterEndIndex + 1);
            }

            var numberStrings = numbers.Split(delimiters.ToArray(), StringSplitOptions.None);
            var negatives = new List<int>();
            var sum = 0;

            foreach (var numberString in numberStrings)
            {
                if (int.TryParse(numberString, out var number))
                {
                    if (number < 0)
                        negatives.Add(number);
                    else
                        sum += number;
                }
            }

            if (negatives.Any())
                throw new ArgumentException($"Negatives not allowed: {string.Join(", ", negatives)}");

            return sum;
        }
    }
}

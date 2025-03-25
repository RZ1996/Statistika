using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistika
{
    public class Calculator
    {
        private List<double> Numbers { get; set; } = new List<double>();

        public Calculator(string input)
        {
           
            SetInput(input);
        }

        public void SetInput(string input)
        {
         
            var parts = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            Numbers = parts.Select(p => double.Parse(p)).ToList();
        }

        public double GetSum() => Numbers.Sum();
        public double GetAverage() => Numbers.Average();
        public double GetMin() => Numbers.Min();
        public double GetMax() => Numbers.Max();
        public string GetOrderedStringAsc() => string.Join(" ", Numbers.OrderBy(n => n));
        public string GetOrderedStringDsc() => string.Join(" ", Numbers.OrderByDescending(n => n));
    }
}

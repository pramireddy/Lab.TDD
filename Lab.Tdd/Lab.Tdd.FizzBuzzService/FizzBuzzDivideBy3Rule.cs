using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Tdd.FizzBuzz
{
    public class FizzBuzzDivideBy3Rule : IFizzBuzzRule
    {
        private int _number;
        public FizzBuzzDivideBy3Rule(int number)
        {
            _number = number;
        }
        public bool IsDivisible()
        {
            return _number % 3 == 0;
        }

        public string Print()
        {
            return "Fizz";
        }
    }
}

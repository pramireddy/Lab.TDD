using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Tdd.FizzBuzz
{
    public class FizzBuzzDivideBy3And5Rule: IFizzBuzzRule
    {
        private int _number;
        public FizzBuzzDivideBy3And5Rule(int number)
        {
            _number = number;
        }
        public bool IsDivisible()
        {
            return (_number % 3 ==0 && _number % 5 == 0);
        }

        public string Print()
        {
            return "FizzBuzz";
        }
    }
}

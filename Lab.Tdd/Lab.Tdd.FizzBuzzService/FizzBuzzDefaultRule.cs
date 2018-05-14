using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Tdd.FizzBuzz
{
    public class FizzBuzzDefaultRule : IFizzBuzzRule
    {
        private int _number;
        public FizzBuzzDefaultRule(int number)
        {
            _number = number;
        }
        public bool IsDivisible()
        {
            return true;
        }

        public string Print()
        {
            return Convert.ToString(_number);
        }
    }
}

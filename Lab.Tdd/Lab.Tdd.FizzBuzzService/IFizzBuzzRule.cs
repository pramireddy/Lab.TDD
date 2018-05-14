using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Tdd.FizzBuzz
{
    public interface IFizzBuzzRule
    {
        bool IsDivisible();
        string Print();
    }
}

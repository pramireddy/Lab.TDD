using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Tdd.FizzBuzz
{
    public class FizzBuzzService
    {
        private IList<IFizzBuzzRule> _setupRules;

        public string Print(int number)
        {
            _setupRules = SetupRules(number);
            //return "1";

            //return Convert.ToString(number);

            //if (number == 3)
            //{
            //    return "Fizz";
            //}
            //else
            //{
            //    return Convert.ToString(number);
            //}

            //if (number % 3 == 0)
            //{
            //    return "Fizz";
            //}
            //else if(number == 5)
            //{
            //    return "Buzz";
            //}
            //else
            //{
            //    return Convert.ToString(number);
            //}


            //if (number % 3 == 0)
            //{
            //    return "Fizz";
            //}
            //else if (number % 5 == 0)
            //{
            //    return "Buzz";
            //}
            //else
            //{
            //    return Convert.ToString(number);
            //}

            //if (number % 3 == 0 && number % 5 == 0)
            //{
            //    return "FizzBuzz";
            //}
            //else if(number % 3 == 0)
            //{
            //    return "Fizz";
            //}
            //else if (number % 5 == 0)
            //{
            //    return "Buzz";
            //}
            //else
            //{
            //    return Convert.ToString(number);
            //}


            // refactor duplicated code

            //if (NumberDivisibleBy3(number) && NumberDivisibleBy5(number))
            //{
            //    return "FizzBuzz";
            //}
            //else if (NumberDivisibleBy3(number))
            //{
            //    return "Fizz";
            //}
            //else if (NumberDivisibleBy5(number))
            //{
            //    return "Buzz";
            //}
            //else
            //{
            //    return Convert.ToString(number);
            //}
            foreach (IFizzBuzzRule rule in _setupRules)
            {
                if (rule.IsDivisible())
                    return rule.Print();
            }
            return Convert.ToString(number);
        }

        //private static bool NumberDivisibleBy3(int number)
        //{
        //    return number % 3 == 0;
        //}

        //private static bool NumberDivisibleBy5(int number)
        //{
        //    return number % 5 == 0;
        //}

        private static IList<IFizzBuzzRule> SetupRules(int number)
        {
            var fizzBuzzRules = new List<IFizzBuzzRule>
            {
                new FizzBuzzDivideBy3And5Rule(number),
                new FizzBuzzDivideBy5Rule(number),
                new FizzBuzzDivideBy3Rule(number)
                //new FizzBuzzDefaultRule(number)
            };

            return fizzBuzzRules;
        }
    }
}

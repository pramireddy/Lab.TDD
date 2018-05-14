using Lab.Tdd.FizzBuzz;
using System;
using System.Linq;
using Xunit;

namespace Lab.Tdd.FizzBuzzServiceTest
{
    public class FizzBuzzServiceTest
    {
        private FizzBuzzService _fizzBuzzService;

        public FizzBuzzServiceTest()
        {
            _fizzBuzzService = new FizzBuzzService();
        }

        [Fact]
        public void PrintShouldBeNumber()
        {
            Assert.Equal("2", _fizzBuzzService.Print(2));
        }

        [Fact]
        public void PrintShouldBeFizz()
        {
            Assert.Equal("Fizz", _fizzBuzzService.Print(3));
            Assert.Equal("Fizz", _fizzBuzzService.Print(6));
        }

        [Fact]
        public void PrintShouldBeBuzz()
        {
            Assert.Equal("Buzz", _fizzBuzzService.Print(5));
            Assert.Equal("Buzz", _fizzBuzzService.Print(10));
        }

        [Fact]
        public void PrintShouldBeFizzBuzz()
        {
            Assert.Equal("FizzBuzz", _fizzBuzzService.Print(15));
        }
    }
}

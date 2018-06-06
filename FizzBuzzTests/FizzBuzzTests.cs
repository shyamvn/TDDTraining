using System;
using EvilFizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void NumbersDivisibleBy3AreReplacedWithFizz()
        {
            var fizzBuzzer = new FizzBuzzer();

            var result = fizzBuzzer.ApplyFizz(1, 2, 3, 4, 5, 6);

            CollectionAssert.AreEqual(new[] { "1", "2", "Fizz", "4", "5", "Fizz" }, result);
        }
    }
}

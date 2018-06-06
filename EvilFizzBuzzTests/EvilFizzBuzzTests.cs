using System;
using EvilFizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EvilFizzBuzzTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NumbersDivisibleBy3AreReplacedWithFizz()
        {
            var fizzBuzzer = new FizzBuzzer();

            var result = fizzBuzzer.ApplyFizz(1, 2, 3, 4, 5, 6);

            CollectionAssert.AreEqual(new[] { "1", "2", "Fizz", "4", "5", "Fizz" }, result);
        }

        [TestMethod]
        public void NumbersDivisibleBy5AreReplacedWithBuzz()
        {
            var fizzBuzzer = new FizzBuzzer();

            var result = fizzBuzzer.ApplyBuzz(1, 2, 3, 4, 5, 6);

            CollectionAssert.AreEqual(new[] { "1", "2", "3", "4", "Buzz", "6" }, result);
        }
    }
}

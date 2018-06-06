using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvilFizzBuzz
{
    public class FizzBuzzer
    {
        public string[] ApplyFizz(params int[] numbers)
        {
            return numbers.Select(i => i % 3 == 0 ? "Fizz" : i.ToString()).ToArray();
        }
    }
}

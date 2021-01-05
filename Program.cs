using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_PD1
{


    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizzOrBuzz = new FizzBuzz();

            Console.WriteLine("Wprowadź liczbe: ");
            string userInputNumber = Console.ReadLine();
            Console.WriteLine( fizzOrBuzz.CheckFizzOrBuzz(userInputNumber) ); 

        }

    }
}

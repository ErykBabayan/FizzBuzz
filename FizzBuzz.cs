using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_PD1
{
    class FizzBuzz
    {
        string fizzOrBuzz;
        int number;


        public string CheckFizzOrBuzz(string userInputNumber)
        {
            


             if(!(int.TryParse(userInputNumber, out number)))
            {
                Console.WriteLine("Wprowadziłeś błędne dane");
            }
            else
            {
            if (number % 3 == 0 && number % 5 == 0)
                fizzOrBuzz = "FizzBuzz";
            else if (number % 3 == 0)
                fizzOrBuzz = "Fizz";
            else if (number % 5 == 0)
                fizzOrBuzz = "Buzz";
            else
                fizzOrBuzz = number.ToString();
            }

                return fizzOrBuzz;
        }

    }




}

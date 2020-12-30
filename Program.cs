using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_PD1
{

    /* Założenia:
    if liczba % 3 == 0 Fizz
    if liczba % 5 == 0 Buzz
    if liczba % 3&&5 == 0 FizzBuzz
    if liczba % 3&&5 != 0 liczba
     */
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

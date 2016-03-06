using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
                Console.WriteLine(i);
            {
                
                if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz ");
                }
                 
                if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }

             
                Console.ReadLine();

            }
            
        }
    }
}

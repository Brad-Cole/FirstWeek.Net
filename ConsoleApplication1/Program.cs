using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treehouse.CodeChallenges
{
    class Program
    {
        static void Main()
        {
            
            Console.Write("Enter the number of times to print \"Yay!\": ");
            string entry = Console.ReadLine();

            try
            {
                int number = Convert.ToInt32(entry);

                for (int i = 0; i < number; i++)
                {
                    Console.WriteLine("Yay!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("This is not valid input.");
            }
            
                Console.WriteLine("You printed \"Yay!\" " + entry + " times!");
            
        }
    }
}
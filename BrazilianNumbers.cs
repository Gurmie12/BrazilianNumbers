/*
 Author : Gurman Brar
 date: Sep - 17 - 2019
 */


using System;

namespace wa2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Requesting a positive integer from the user
            Console.Write("Enter a positive integer: ");
            int n = int.Parse(Console.ReadLine());

            /* We produce base values from 2 to a number 1 less than the user input.
             Sincce 1 and 0 are invalid and the number mode itself is. */
            for (int b = n -1; b >= 2; b--)
            {
                int y = n;            // This is so the input can reset in the next iteration.
                int holder = y % b;
                bool same = true;     // Control for the while and if statements.
                int counter = 0;

                // While the changing integer value is not zero the testing of bases continues.
                while (y != 0 && same)
                {
                    if (y % b == holder) // If the remainders are the same, we add one to the counter
                    {
                        counter++;
                        y = y / b;
                    }
                    else
                    {
                        same = false;
                       
                    }
                }
                if (same)               // If the bool variable "same" is still true we print the results.
                {
                    Console.Write(n + " in base 10 is ");
                    Console.Write(holder);
                    for(int x = 1; x < counter; x++) // Displays the remainder as many times as the counter variable counted.
                    {
                        Console.Write(" , " + holder);
                    }
                    Console.WriteLine(" in base " + b);
                }
           
            }
      
        }
    }
}

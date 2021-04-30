using System;

namespace Exceptions
{
    class HandlingExceptions
    {
        public static void Main(string[] args)
        {
            // Boolean to determine if the user want or not to try again
            bool leave = false;

            // All the program embeded in a do while loop for restart if needed
            do
            {
                // Actually starting the program
                try
                {
                    Console.WriteLine("Choose a short number (-32,768 to 32,767): ");
                    short input = short.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
                // Catch any type of exception -- in case it appears
                catch (Exception e)
                {
                    Console.WriteLine();
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                }
                // Finish the 'try'
                finally
                {
                    Console.WriteLine("Program finished. Wanna try it again?");
                    Console.WriteLine("Type 1 to try again or anything to leave: ");
                    int aux = Convert.ToInt32(Console.ReadLine());  // An auxiliar variable just to store the user's response and ste the leave option
                    Console.WriteLine();

                    // Set the leave option
                    if (aux == 1)
                    {
                        // Try again the program
                        leave = false;
                    }
                    else
                    {
                        // Leave the program
                        leave = true;
                    }
                }
            }
            while (leave == false);
        }
    }
}

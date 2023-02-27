using System;

namespace Variables_Babcock_Olivia
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declares an integer to store a favorite number
            int favoriteNumber;
            //Booleans initialized to false for jumping and running
            bool isJumping = false, isRunning = false;
            // Declared random float variable
            float myFloat;
            // Assigning the favoriteNumber to 11
            favoriteNumber = 11;
            // Assigning myFloat to 23.93
            myFloat = 23.93f;
            // Initializing constant finalGrade to 5
            const double finalGrade = 5.0;

            // Prints all variables to console
            Console.WriteLine(favoriteNumber);
            Console.WriteLine(isJumping);
            Console.WriteLine(isRunning);
            Console.WriteLine(myFloat);
            Console.WriteLine(finalGrade);
            
        }
    }
}

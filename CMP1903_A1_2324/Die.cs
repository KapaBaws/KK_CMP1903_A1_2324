using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        public int DieValue { get; set; } // Allows for Die to be able to hold a value.

        public static Random random = new Random(); // Creates a static class which is able to generate random numbers.
        
        public int Roll() // A class which rolls the dice and gives it a value.
        {
            DieValue = random.Next(1,7); // Generates a random number from 1-6 and assigns it to DieValue.
            return DieValue; // Returns the value of the die.
           
        }
        
    }
}

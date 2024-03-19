using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        public static void testGame()
        {
            Die die = new Die();
            int dieValue = die.Roll(); // Rolls the dice and stores its value.
            Debug.Assert(dieValue >= 1 && dieValue <= 6, "The result of the die roll is not between 1 and 6"); // Makes sure that the value the dice is assigned to is within the range of 1-6.
            Game game = new Game(); // Creates an instance of the Game class.
            int total = game.diceGame(); // Runs the dice game and stores its values.
            Debug.Assert(total >= 3 && total <= 18, "The result do not meet the upper and lower bounds."); // Makes sure that the total value of the 3 dice is within 3-18.
        }
    }
}

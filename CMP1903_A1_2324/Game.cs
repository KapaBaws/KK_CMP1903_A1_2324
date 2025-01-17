using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        public int diceGame()
        {
            // creates 3 dice which can be rolled and store a value.
           int  die1 = new Die().Roll();
           int die2 = new Die().Roll();
           int die3 = new Die().Roll();

            // Prints the value of each dice and their total.
            Console.WriteLine($"Dice 1:{die1}\nDice 2:{die2}\nDice 3:{die3}");
            Console.WriteLine($"The total is: {die1 + die2 + die3}");
            return (die1 + die2 + die3);
        }

        // A method which allows the user to keep rolling until 'Exit' is entered.
        public void repeat()
        {
            int isRunning = 1;

            while(isRunning == 1)
            {
                Console.WriteLine("Press Enter to run the game again.Type 'Exit' to quit");
                string input = Console.ReadLine(); 
                Console.WriteLine(input);

                if (input.ToLower() == "exit")
                {
                    isRunning = 0;  
                }

                // Runs the dice game.
                diceGame();
            }

        }

    }
}

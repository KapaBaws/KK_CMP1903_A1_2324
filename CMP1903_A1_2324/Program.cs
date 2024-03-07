using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game dieGame = new Game();
            dieGame.diceGame(); // Runs the dice game.
            dieGame.repeat(); // Allows for the game to be repeated until user exits.
            Testing.testGame(); // Tests the game for errors.
        }
    }
}

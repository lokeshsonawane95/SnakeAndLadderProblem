using System;

namespace SnakeAndLadderProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            int playerPosition = 0, diceRoll;
            Random rand = new Random();
            diceRoll = rand.Next(1, 7);
            Console.WriteLine("Number appeared on dice is : " + diceRoll);
        }
    }
}
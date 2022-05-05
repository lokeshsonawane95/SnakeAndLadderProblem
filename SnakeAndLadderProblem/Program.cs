using System;

namespace SnakeAndLadderProblem
{
    class Program
    {
        //Declaring constants for Logic 2
        public const int noPlay = 0;
        public const int ladder = 1;
        public const int snake = 2;
        public static void Main(string[] args)
        {
            int playerPosition = 0, diceRoll, playerOption, listIndex;
            Random rand = new Random();
            string[] choiceArray = { "noPlay", "ladder", "snake" };
            while (playerPosition < 100)
            {
                //Dice rolling logic
                diceRoll = rand.Next(1, 7);
                Console.WriteLine("Number appeared on dice is : " + diceRoll);

                //Player Options generation "Array" "Logic 1"
                listIndex = rand.Next(choiceArray.Length);
                Console.WriteLine("Player Option is : " + choiceArray[listIndex]);

                //Player Options generation "Random" "Logic 2"
                /*playerOption = rand.Next(0, 3);
                switch (playerOption)
                {
                    case noPlay:
                        Console.WriteLine("Player Option is : No Play");
                        break;
                    case ladder:
                        Console.WriteLine("Player Option is : Ladder");
                        break ;
                    case snake:
                        Console.WriteLine("Player Option is : Snake");
                        break;
                }*/

                //Actions according to player option
                if (choiceArray[listIndex] == "ladder")
                {
                    if ((playerPosition + diceRoll) > 100)
                    {
                        playerPosition = 100;
                    }
                    else
                    {
                        playerPosition += diceRoll;
                    }
                }
                else if (choiceArray[listIndex] == "snake")
                {
                    if (playerPosition < diceRoll)
                    {
                        playerPosition = 0;
                    }
                    else
                    {
                        playerPosition -= diceRoll;
                    }
                }
                Console.WriteLine("Player Position : " + playerPosition);
            }
            Console.WriteLine("Last Player Position is : " + playerPosition);
        }
    }
}
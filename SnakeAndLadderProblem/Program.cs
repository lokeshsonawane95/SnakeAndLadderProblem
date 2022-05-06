using System;

namespace SnakeAndLadderProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            //To assign the winning player
            int win = 0;

            //Two players
            int[] player = { 0, 0 };

            //Dice counts of each one
            int[] playerDice = { 0, 0 };

            int diceRoll, arrayIndex;
            Random random = new Random();
            string[] choiceArray = { "noPlay", "ladder", "snake" };
            int turn = 0;
            while (player[0] < 100 && player[1] < 100)
            {
                Console.WriteLine("\nPlayer" + (turn + 1) + " is playing");
                Console.WriteLine("Player" + (turn + 1) + " position is : " + player[turn]);

                //Dice rolling logic
                diceRoll = random.Next(1, 7);
                playerDice[turn]++;
                Console.WriteLine("Player" + (turn + 1) + " dice rolls are : " + playerDice[turn]);
                Console.WriteLine("Number appeared on dice is : " + diceRoll);

                //Player Options generation "Array"
                arrayIndex = random.Next(choiceArray.Length);
                Console.WriteLine("Player Option is : " + choiceArray[arrayIndex]);

                //Actions according to player option
                if (choiceArray[arrayIndex] == "noPlay" && turn == 0)
                {
                    turn = 1;
                    continue;
                }
                else if (choiceArray[arrayIndex] == "noPlay" && turn == 1)
                {
                    turn = 0;
                    continue;
                }
                if (choiceArray[arrayIndex] == "ladder")
                {
                    //If player position goes beyond 100
                    if ((player[turn] + diceRoll) >= 100)
                    {
                        player[turn] = 100;
                        win = turn;
                        break;
                    }
                    else
                    {
                        player[turn] += diceRoll;
                        continue;
                    }
                }
                else if (choiceArray[arrayIndex] == "snake")
                {
                    //If player position is less than the number appeared on dice
                    if (player[turn] < diceRoll)
                    {
                        player[turn] = 0;
                    }
                    else
                    {
                        player[turn] -= diceRoll;
                    }
                }

                //If any player reaches to 100
                if (player[0] == 100 || player[1] == 100)
                {
                    win = turn;
                    break;
                }

                //Changing turns
                if (turn == 0)
                {
                    turn = 1;
                }
                else
                {
                    turn = 0;
                }
            }
            Console.WriteLine("Winner Player is : Player" + (win + 1));
            Console.WriteLine("Player position is : " + player[win]);
        }
    }
}
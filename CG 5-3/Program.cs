using System;

namespace CG_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play a dice game! First to twenty wins!");
            
            //setting my score
            int myTotal = 0;
            //setting the computers score
            int compTotal = 0;
            //initialize new Random() for random number generation
            Random rnd = new Random();

            //set the code to 'roll' the dice until someone totals 20
            while (myTotal < 20 && compTotal < 20)
            {
                                //show what i rolled this 'turn'
                Console.Write("I rolled: ");
                //add my roll with my total
                myTotal += RollDice(rnd);
                //exit loop if i won
                Console.WriteLine(" My total score is " + myTotal+ " ");
                // if I win the game will end and the method will output my winner message
                if (iWon(myTotal))
                {
                    break;
                }
                else //if i didn't win the loop will keep going and roll for the computer
                {
                     //show what the computer rolled this turn
                    Console.Write("Computer rolled: ");
                    //add computers roll with its total
                    compTotal += RollDice(rnd);
                    Console.WriteLine("The Computers total score is " + compTotal+ " ");
                }
            }

            //print winner
            printWinner(myTotal);
            Console.ReadLine();

        }
   
        private static int RollDice(Random rnd)
        {
            //set to show a number from 1 to 6 for first dice
            int dice1 = rnd.Next(1, 7);
            //same as above for second dice, random between 1 and 6
            int dice2 = rnd.Next(1, 7);
            //display what was rolled from dice1 and dice2
            Console.Write(dice1 + " and a " + dice2 + "\n\n");
            //return the total of the two dice
            return dice1 + dice2;
        }

        //this method prints the winner
        private static void printWinner(int myTotal)
        {
            string winner;
            //whoever got 20 first wins
            winner = myTotal >= 20 ? "I won :D !" : "Computer won :(";
            //show the winner on the screen :) 
            Console.WriteLine(winner);
        }

        private static bool iWon(int myTotal)
        {
            return myTotal >= 20;
        }
    }
}

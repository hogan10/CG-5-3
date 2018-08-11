using System;

namespace CG_5_3
{
    class Program
    {
        const int WINNING_VALUE = 20;

        const int DICE_SIDES = 6;

        static void Main(string[] args)
        {



           //The user and the computer are both starting from 0. This must be defined so that there is a starting point to track the score

            int userPoints = 0;

            int computerPoints = 0;

            //The next value to consider is the total of the dice.  This will be used in the randomizer

            int diceTotal;

            //Here I use bool because you need the computer and the user to take turns. Without this, there would be no turn for the computer, only the user

            bool userTurn = true;



            //do/while also switches the turn of user and computer

            do

            {

                //below we are referencing the method. This allows the method to perform the randomizer and roll the dice.  

                diceTotal = RollDice();



                //next we need if/else if/else statements to continue the game and prompt the user for their turn. We also need to collect scorse so we know who reaches 20 first and wins

                if (userTurn)

                {

                    Console.WriteLine("It's your turn. Please press enter to roll the dice!");
                    Console.ReadLine();



                    Console.WriteLine("Your total is: " + diceTotal);

                    //we need to keep a running total of the user's score. THis can be done by adding the dicetotal to the current user points

                    userPoints += diceTotal;

                }

                else

                {

                    Console.WriteLine("Now it is the computer's turn: ");

                    Console.WriteLine();

                    Console.WriteLine("The computer's total is:  " + diceTotal);



                    computerPoints += diceTotal;

                }

                Console.WriteLine("The user's score is: " + userPoints);

                Console.WriteLine("The computer's score is: " + computerPoints);

                Console.WriteLine();

                userTurn = !userTurn;



                //the game is the first to reach twenty. if after the first rolls neither have reached twenty we have to keep going
                //this can be done using do/while. If the point total is less than the winning value total then we keep going

            }
            //this compares BOTH user points and computer points. We need to know that both are still under 20
            while (userPoints < WINNING_VALUE && computerPoints < WINNING_VALUE);

            //we use if else to evaluate the different options. starting with the user - if they have 20 or more poitns they win! if they don't the computer wins and they lose
            if (userPoints >= WINNING_VALUE)

            {

                Console.WriteLine("You win!");

            }

            else

            {

                Console.WriteLine("The computer wins! You have lost. :( ");

            }

            Console.ReadLine();



        }
/// <summary>
/// randomly rolls the dice and adds them together
/// </summary>
/// <returns>dice total</returns>


            //Should I split this into two methods since it is technically doing two tasks - rolling the dice randomly and adding the totals?
        private static int RollDice()

        {
            int die1;

            int die2;

            //use the randomizer to randomly "roll" the dice
            Random randomizer = new Random();



            die1 = randomizer.Next(1, DICE_SIDES + 1);

            die2 = randomizer.Next(1, DICE_SIDES + 1);


            return (die1 + die2);

        }
    }
}

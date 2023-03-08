using System;

namespace ShootingDice
{

    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {

        public string Prompt {get; set;}

       public override void Play(Player other)
       {
        Console.WriteLine("What number would you like to roll? : ");
        //make a variable for the answer
        //int that answer so they can enter a number 
        //do readline command

        string answer = Console.ReadLine().Trim();
        int numAnswer;
        bool isNumber = int.TryParse(answer, out numAnswer);

             int myRoll = numAnswer;
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                Console.WriteLine($"{other.Name} Wins!");
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }

        }
    }
}
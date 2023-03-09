using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player that throws an exception when they lose to the other player
    // Where might you catch this exception????
    public class SoreLoserPlayer: Player
    {
        //some code I found online for custom exception

        // class MyCustomException : Exception
        // {
        //     public MyCustomException(string message)
        //         : base(message)
        //     {
        //         message = "If I lose we all lose";
        //     }
        // }


    public override void Play(Player other)
        {
            // Call roll for "this" object and for the "other" object
            int myRoll = Roll();
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            try 
            {
                if (myRoll > otherRoll)
                {
                    Console.WriteLine($"{Name} Wins!");
                }
            
                else if (myRoll < otherRoll)
                {
                    
                    Console.WriteLine($"{other.Name} Wins!");
                    throw new Exception($"{Name}: If I LOSE WE ALL LOSE");
                }
                else
                {
                    // if the rolls are equal it's a tie
                    Console.WriteLine("It's a tie");
                }
            }
            catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            
        }
    }
}


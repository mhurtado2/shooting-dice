using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; }
    

        public override void GetInsult()
        {
            Console.WriteLine("That Roll was terrible");
        }
    }
}
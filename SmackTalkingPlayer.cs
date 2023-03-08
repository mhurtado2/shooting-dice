using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer
    {
        public string Taunt { get; }
    

        public virtual void Insult()
        {
            Console.WriteLine("That Roll was terrible");
        }
    }
}
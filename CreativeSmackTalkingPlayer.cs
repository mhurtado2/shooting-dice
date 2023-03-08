using System.Collections.Generic;
using System;
using System.Linq;


namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
            // List<string> Insults = new List<string>(){
            //     "You’re my favorite person besides every other person I’ve ever met.", 
            //     "Did your parents have any children that lived?", 
            //     "I envy people who have never met you.",
            //     "You’re kinda like Rapunzel except instead of letting down your hair, you let down everyone in your life."
            // };

            //make a random function
            //create a blank list to add index of insults to
            //relate the int index back to insults to get string value of int index
            //make a loop that loops through 
            public override void GetInsult()
            {
                 List<string> Insults = new List<string>(){
                "You’re my favorite person besides every other person I’ve ever met.", 
                "Did your parents have any children that lived?", 
                "I envy people who have never met you.",
                "You’re kinda like Rapunzel except instead of letting down your hair, you let down everyone in your life."
            };


            List<String> selectInsults = new List<string>{};
            while(selectInsults.Count < 1)
            {
                Random random = new Random();
                int  randomInsultIndex= new Random().Next(0, 4);
                // Console.WriteLine(randomInsultIndex);
                if(!selectInsults.Contains(Insults[randomInsultIndex]))
                {
                    selectInsults.Add(Insults[randomInsultIndex]);
                }
                    Console.WriteLine(Insults[randomInsultIndex]);
            }
         }
    }
}
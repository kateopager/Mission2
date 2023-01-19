using System;

namespace Mission2
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string rollCount = "";

            Console.Write("Welcome to the dice throwing simulator! " + "How many dice rolls would you like to simulate?");
            rollCount = Console.ReadLine();

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each '*' represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + rollCount);

            int rollrandom = new Random(); //trying to decide where to put this

            int rolls = int.Parse(rollCount); //turn the roll input into an integer

            for ( int r = 0; r < rolls; r++) //set up a for loop that starts with the first roll and stops at the roll count given by the user
            {

                //need to set up another for loop that has an array which will add an asterik to the correct number for each time it is hit


            }




        }

        private static void PrintName(string rollCount)
        {
            throw new NotImplementedException();
        }
    }
}

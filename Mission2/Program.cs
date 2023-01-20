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

            // the user sets the number of rolls total to be made, turn it into an integer
            // need to roll the total amount of times given by the user 
            // assign each roll a random number for each dice 
            // combine the total of the dice
            // keep count of each roll's sum option in an array
            // print lines for each sum option number, a * for each 1% of the total rolls

            int rolls = int.Parse(rollCount); //turn the roll input into an integer so that it can be used in loop counting

            Random rnd = new Random(); // declare a random variable class which will be called later

            int[] sumrolls = new int[13]; //create an array that will hold the 11 possible values from the dice (numbers 2-12)

            for (int r = 0; r < rolls; r++) //set up a for loop that starts with the first roll and stops at the roll count given by the user
            {
                int Dice1 = rnd.Next(1, 7); //roll each dice by using the random number generator
                int Dice2 = rnd.Next(1, 7);
                int RollTotal = Dice1 + Dice2; //we are using the sum of the die so we need to add them up

                sumrolls[RollTotal]++; //put the roll total in the array spot
            }
            for (int i = 1; i < 12; i++) //this will print out the results from the array to the user
            {
                Console.WriteLine((i + 1) + " : " + sumrolls[i]);
            }

            //need to set up another for loop that has an array which will add an asterik to the correct number for each time it is hit


            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");


        }

        private static void PrintName(string rollCount)
        {
            throw new NotImplementedException();
        }
    }
}

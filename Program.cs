// Garrett Ashcroft - Section 002
// Mission 2
// Program that simulates the rolling of 2 dice

//Program.cs

using Mission2;
using System;
internal class Program
{

    public static void Main(string[] args)
    {
        // Create a new instance of the rollDice class
        RollDice rd = new RollDice();
        
        // Get user input 
        System.Console.WriteLine("Welcome to the dice throwing simulator!  \r\nHow many dice rolls would you like to simulate?");

        // Set the input to the rolls variable 
        int rolls = int.Parse(System.Console.ReadLine());

        // Variable assigned to the array reurned from the rolls method
        double[] sOutput = rd.Roll(rolls);


        // Print the given output
        System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        System.Console.WriteLine("Total number of rolls = " + rolls);

        // For loop that prints the combinations 2-12 and accesses each element of the array
        for (int iCount = 0; iCount < sOutput.Length; iCount++)
        {
            // One asterisk per percent, not one per roll***
            // Get the percentage from the array
            int percentage = (int)System.Math.Round((double)sOutput[iCount]);

            // Add an aserisk for each percentage
            string asterisks = new string('*', percentage);

            // Print the histogram in the console
            System.Console.WriteLine($"{iCount + 2}: {asterisks}");
        }
        System.Console.WriteLine("\r\nThank you for using the dice throwing simulator.  Goodbye!");
    }
}
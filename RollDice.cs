// Garrett Ashcroft - Section 002
// Mission 2
// Program that simulates the rolling of 2 dice

// RollDie.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    internal class RollDice
    {
        public double[] Roll(int rolls) // Constructor is only run one time, the first time the class is instantiated
        {
            // Import random
            Random random = new Random();

            // Create an empty array expecting a decimal
            double[] aResults = new double[11];

            // For loop that rolls dice for each time the user entered
            for (int iOuter = 0; iOuter < rolls; iOuter++)
            {
                // Assigns both dice a 1-6 value
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);

                // Sums the roll
                int rollSum = dice1 + dice2;

                // Has a count of each time a combination is rolled 2-12
                aResults[rollSum - 2] += 1;
            }

            // For loop that changes the count into a percentage
            for (int iInner = 0; iInner < aResults.Length; iInner++) 
            {
                // Changes value in the array to the percentage
                double timesRolled = aResults[iInner];
                aResults[iInner] = timesRolled/rolls * 100;
            }
            // Returns the array
            return aResults;
        }
    }
}

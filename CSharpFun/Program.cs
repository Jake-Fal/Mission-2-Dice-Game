using System;

namespace RollDiceGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Welcome to the dice throwing simulator \nHow many dice rolls would you like to simulate? ");
            int numRolls = Int32.Parse(Console.ReadLine());
            int iCount = 0;
            int[] rolls = new int[numRolls];
            int i = 0;
            int[] numArrays = new int[11];
            double[] numAst = new double[11];

            while (iCount < numRolls)
            {
                var r = new Random();
                int firstRoll = r.Next(1, 7);
                int secRoll = r.Next(1, 7);
                int finNum = firstRoll + secRoll;
                rolls[iCount] = finNum;
                iCount++;
            }
            Console.Write("\n\nDICE ROLLING SIMULATION RESULTS \nEach  '*'  represents 1% of the total number of rolls. \nTotal number of rolls = " + numRolls + ".\n");
            foreach (int l in rolls)
            {
                if (l == 2)
                {
                    numArrays[0]++;
                }
                if (l == 3)
                {
                    numArrays[1]++;
                }
                if (l == 4)
                {
                    numArrays[2]++;
                }

                if (l == 5)
                {
                    numArrays[3]++;
                }

                if (l == 6)
                {
                    numArrays[4]++;
                }

                if (l == 7)
                {
                    numArrays[5]++;
                }

                if (l == 8)
                {
                    numArrays[6]++;
                }
                if (l == 9)
                {
                    numArrays[7]++;
                }
                if (l == 10)
                {
                    numArrays[8]++;
                }
                if (l == 11)
                {
                    numArrays[9]++;
                }
                if (l == 12)
                {
                    numArrays[10]++;
                }
            }

            for (int r = 0; r < numArrays.Length; r++)
            {
                numAst[r] = ((Convert.ToDouble(numArrays[r]) / Convert.ToDouble(numRolls) / .01));
                numAst[r] = Math.Round(numAst[r]);
                numAst[r] = Convert.ToInt32(numAst[r]);
            }
            for (int b=0; b<numAst.Length; b++)
            {
                Console.Write((b+2) + ": ");
                for (int q = 1; q < numAst[b]; q++)
                    Console.Write("* ");
                Console.Write("\n");
            }

        }
    }
}

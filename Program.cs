using System;

namespace ForMachine
{
    /// <summary>
    /// The class has a private int array, which can have one or more elements, no limit,
    /// Set up at construction (new) and can't changes anymore
    /// Has a public int (Step). At the first read 'Step' gives back the 0th element
    /// Of the array. Each reads it increment the indexer of the array and gives back
    /// Another element of the array. When its reach the end of the array, starts over
    /// With the 0th element. So Rolls over. Roller.
    /// </summary>
    public class Roller
    {
        private int tempData;
        private int[] budget;
        private int indexer;

        public int Step
        {
            get
            {
                tempData = budget[indexer];
                if (indexer >= budget.Length - 1)
                {
                    indexer = 0;
                }
                else
                {
                    indexer++;
                }
                return tempData;
            }
        }

        #region Constructors
        /// <summary>
        /// initialize Roller to step 1
        /// </summary>
        public Roller()
        {
            indexer = 0;
            tempData = 0;
            budget = new int[1] { 1 };
        }
        /// <summary>
        /// initialize Roller with one step
        /// </summary>
        /// <param name="p1">step with whole number param 1</param>
        /// <param name="p2">step with whole number param 2</param>
        public Roller(int p1)
        {
            indexer = 0;
            tempData = 0;
            budget = new int[1] { p1 };
        }
        /// <summary>
        /// initialize Roller with two steps
        /// </summary>
        /// <param name="p1">step with whole number param 1</param>
        /// <param name="p2">step with whole number param 2</param>
        public Roller(int p1, int p2)
        {
            indexer = 0;
            tempData = 0;
            budget = new int[2] { p1, p2 };
        }
        /// <summary>
        /// initialize Roller with three steps
        /// </summary>
        /// <param name="p1">step with whole number param 1</param>
        /// <param name="p2">step with whole number param 2</param>
        /// <param name="p3">step with whole number param 3</param>
        public Roller(int p1, int p2, int p3)
        {
            indexer = 0;
            tempData = 0;
            budget = new int[3] { p1, p2, p3 };
        }
        /// <summary>
        /// initialize Roller with an array of steps
        /// </summary>
        /// <param name="param">the array contains whole numbers</param>
        public Roller(int[] param)
        {
            indexer = 0;
            tempData = 0;
            budget = new int[param.Length];
            budget = param;
        }
        #endregion
    }

    class Program
    {
        public static int[] ForMachine(int[] workArray, int start, int howManyItem, Roller stepPattern )
        {
            Console.WriteLine(1 - 2 < 0);

            int[] tempArray = new int[howManyItem];
            int indexer = start - 1;
            int step = 0;
            for (int counter = 1; counter <= howManyItem; counter++)
            {
                Console.WriteLine("counter: " + counter + "\t elem in workArray: " + indexer + "\t value: " + workArray[indexer] + "\tprevious step: " + step);
                tempArray[counter - 1] = workArray[indexer];
                step = stepPattern.Step;
                indexer += step;
                if (indexer > workArray.Length - 1)
                {
                    int temp = indexer - workArray.Length ;
                    indexer = temp;
                }

                if (indexer < 0)
                {
                    int temp = workArray.Length + indexer;
                    indexer = temp;
                }
            }

            return tempArray;
        }

        static void Main()
        {   
            // Example of usage:

            int[] lista = { 12, 22, 43, 13, 87, 45, 61, 84, 51, 86, 41, 74, 13, 75, 97, 11, 54, 39, 24, 93, 81, 55, 26, 46, 58, 52, 56 };
            int[] listb = { 3, 5, 1, 7, 4, 2, 4, 5, 6 };
            Console.WriteLine("The content of the array:");
            foreach (int cont in listb){ Console.Write(cont + " "); } Console.WriteLine(" ");


            Roller StepPattern = new Roller(new int[] { +2, -1, +4 });
            Roller series = new Roller(new int[] { -3, +4, -2, +7, +3, +2, +1 });
            int startItemInArray = 4;
            int howManyItemToProcess = 9;
            int[] result = new int[howManyItemToProcess];

            result = ForMachine(listb, startItemInArray, howManyItemToProcess, StepPattern);

            Console.WriteLine("\nResult: ");
            foreach (int cont in result) { Console.Write(cont + " "); } Console.WriteLine(" ");
            Console.ReadKey();
        }
    }
}
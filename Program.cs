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
        static void Main()
        {   
            // Example of usage:
            int[] lista = { 12, 22, 43, 13, 87, 45, 61, 84, 51, 86, 41, 74, 13, 75, 97, 11, 54, 39, 24, 93, 81, 55, 26, 46, 58, 52, 56 };
            Console.WriteLine("The content of the array:");
            foreach (int cont in lista)
            {
                Console.Write(cont + " ");
            }
            Console.WriteLine(" ");

            Roller StepPattern = new Roller( new int[]{3, -2, 4, -1, 2 } );

            int start = 2;
            int howManyItem = 13;
            int indexer = start;

            for (int counter = 1; counter <= howManyItem; counter++)
            {
                Console.WriteLine("element id: " + counter + "\t element in array: " + lista[indexer]);
                indexer += StepPattern.Step;
            }

            Console.ReadKey();
        }
    }
}
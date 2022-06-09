using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {





        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            var arrayOfFifty = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(arrayOfFifty);

            //TODO: Print the first number of the array
            Console.WriteLine(arrayOfFifty[0]);

            //TODO: Print the last number of the array
            Console.WriteLine(arrayOfFifty[49]);

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(arrayOfFifty);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");
            ReverseArray(arrayOfFifty);
            Array.Reverse(arrayOfFifty);



            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(arrayOfFifty);


            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            int[] arraySortVal = arrayOfFifty;
            for (int i = 0; i < arraySortVal.Length; i++)
            { Array.Sort(arraySortVal);
                Console.WriteLine(arraySortVal[i]); }


            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            var listOfFifty = new List<int>();


            //TODO: Print the capacity of the list to the console
            Console.WriteLine(listOfFifty.Capacity);


            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this
            Populater(listOfFifty);


            //TODO: Print the new capacity
            Console.WriteLine(listOfFifty.Capacity);



            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            var userIntQuery = int.TryParse(Console.ReadLine(), out int userInput);
            if (!userIntQuery)
            {
                Console.WriteLine("That is not a integer. Please try again.");
            }
            else
            {
                NumberChecker(listOfFifty, userInput);
            }



            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(listOfFifty);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(listOfFifty);
            NumberPrinter(listOfFifty);

            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            listOfFifty.Sort();
            NumberPrinter(listOfFifty);

            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            int[] arrayFromList = listOfFifty.ToArray();
            //for (int i = 0; i< arrayFromList.Length; i++)
            //    Console.WriteLine(arrayFromList[i]);
            NumberPrinter(arrayFromList);


            //TODO: Clear the list
            Console.WriteLine("proof of cleared list");
            listOfFifty.Clear();
            NumberPrinter(listOfFifty);

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 != 0)
                {
                    Console.WriteLine(numbers[i]);
                }
                else
                { Console.WriteLine(0); }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = numberList.Count - 1; i >= 0; i--) //index shifting caused by removal of values when the for loop is incremented from zero. Therefore, needs to decrement.
            {
                if (numberList[i] % 2 != 0)
                { numberList.Remove(numberList[i]); }
                
            }

        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            int i = 0;
            foreach (int number in numberList)
            {

                if (number == searchNumber)
                    i++;
            }
            Console.WriteLine($"The number you entered appears {i} times in this list!");

        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int i = 0; i < 50; i++)
            {
                numberList.Add(rng.Next(0, 50));
            }

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(0, 50);
            }


        }

        private static void ReverseArray(int[] array)
        {
            for (int i = 49; i > 0; i--)
            {
                int value = array[i];
                Console.WriteLine(value);
            }
        }
        

    /// <summary>
    /// Generic print method will iterate over any collection that implements IEnumerable<T>
    /// </summary>
    /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
    /// <param name="collection"></param>
    private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
        
    }
}

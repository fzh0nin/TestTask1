using System;

namespace Task1
{

    static class NewYear
    {
        /*
         * Function returns max number of gifts
         * Counts the limits of a number of candies/tangerines/apples that can fit the bag
         * Than brute force all the variations of bag filling from 0->limits
         */
        static uint CountMaxGiftsNumber(uint candyWeight, uint tangerineWeight, uint appleWeight, uint bagCapacity)
        {
            uint maxNumberOfCandies = bagCapacity / candyWeight;
            uint maxNumberOfTangerines = bagCapacity / tangerineWeight;
            uint maxNumberOfApples = bagCapacity / appleWeight;
            uint maxNumberOfGifts = 0;

            for (uint candiesNumber = 0; candiesNumber <= maxNumberOfCandies; candiesNumber++)
            {
                for (uint tangerinesNumber = 0; tangerinesNumber <= maxNumberOfTangerines; tangerinesNumber++)
                {
                    for (uint applesNumber = 0; applesNumber <= maxNumberOfApples; applesNumber++)
                    {
                        if (candiesNumber * candyWeight + tangerinesNumber * tangerineWeight + applesNumber * appleWeight == bagCapacity)
                            maxNumberOfGifts++;
                    }
                }
            }

            return maxNumberOfGifts;
        }
        /* 
        * Gets a value from console, if it's convertable to unsigned int and the value is not a 0, 
        * returns an unsigned int value, otherwise writes a message asking to enter a new value while not correct.
        */
        private static uint GetUIntFromConsole()
        {
            uint value = 0;

            bool valueIsCorrect = false;
            while (!valueIsCorrect)
            {
                valueIsCorrect = uint.TryParse(Console.ReadLine(), out value) && value != 0;
                if (!valueIsCorrect)
                {
                    Console.WriteLine("That's not a correct number, please try again");
                }
            };
            return value;
        }

        static void Main(string[] args)
        {
            
                Console.WriteLine("Enter the weight of a candy");
                uint x1 = GetUIntFromConsole();
                Console.WriteLine("Enter the weight of a tangerine");
                uint y1 = GetUIntFromConsole();
                Console.WriteLine("Enter the weight of an apple");
                uint z1 = GetUIntFromConsole();
                Console.WriteLine("Enter bag capacity");
                uint w1 = GetUIntFromConsole();
                Console.Write("Max number of gifts is: ");
                Console.WriteLine(CountMaxGiftsNumber(x1, y1, z1, w1)); //Function invokation
            
        }
    }
}

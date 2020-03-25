using System;

namespace Task1
{
    

    static class NewYear
    {
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
            while (true)
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
                Console.WriteLine(CountMaxGiftsNumber(x1, y1, z1, w1));
            }
        }
    }
}

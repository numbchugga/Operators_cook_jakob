using System;

namespace Operators_cook_jakob
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initializes an integer that multiplies two integers
            int intMult = 6 * 45;
            // Initislized an integer that adds to integers
           int intAdd = 55 + 66;
            // Prints the maximum and minimum of the two integer varibles
            Console.WriteLine($"The max of {intMult} and {intAdd} is{Math.Max(intMult, intAdd)}. " +
                $"The min  of the two is {Math.Min(intMult, intAdd)}.");
            // initializes boolean to see if intMult is greater than intAdd
            bool isIntGreater = intMult > intAdd;
            // prints if intMult is greater than intAdd
            Console.WriteLine($"{intMult} is greater than {intAdd}, {isIntGreater}.");




            // Initializes an shorteger that multiplies two shortegers
            short shortMult = 6 * 45;
            // Initislized an shorteger that adds to shortegers
            short shortAdd = 55 + 66;
            // Prints the maximum and minimum of the two shorteger varibles
            Console.WriteLine($"The max of {shortMult} and {shortAdd} is{Math.Max(shortMult, shortAdd)}. " +
                $"The min  of the two is {Math.Min(shortMult, shortAdd)}.");
            // initializes boolean to see if shortMult is greater than shortAdd
            bool isIntGreater = shortMult > shortAdd;
            // prints if shortMult is greater than shortAdd
            Console.WriteLine($"{shortMult} is greater than {shortAdd}, {isshortGreater}.");


            // Initializes an integer that multiplies two longegers
            long longMult = 6 * 45;
            // Initislized an longeger that adds to longegers
            long longAdd = 55 + 66;
            // Prints the maximum and minimum of the two longeger varibles
            Console.WriteLine($"The max of {longMult} and {longAdd} is{Math.Max(longMult, longAdd)}. " +
                $"The min  of the two is {Math.Min(longMult, longAdd)}.");
            // initializes boolean to see if longMult is greater than longAdd
            bool islongGreater = longMult > longAdd;
            // prints if longMult is greater than longAdd
            Console.WriteLine($"{longMult} is greater than {longAdd}, {islongGreater}.");



            // Initializes an floateger that multiplies two floategers
            float floatMult = 6.5f * 45.24f;
            // Initislized an floateger that adds to floategers
            float floatAdd = 55.35f + 66.15f;
            // Prints the maximum and minimum of the two floateger varibles
            Console.WriteLine($"The max of {floatMult} and {floatAdd} is{Math.Max(floatMult, floatAdd)}. " +
                $"The min  of the two is {Math.Min(floatMult, floatAdd)}.");
            // initializes boolean to see if floatMult is greater than floatAdd
            bool isfloatGreater = floatMult > floatAdd;
            // prints if floatMult is greater than floatAdd
            Console.WriteLine($"{floatMult} is greater than {floatAdd}, {isfloatGreater}.");



            // Initializes an doubleeger that multiplies two doubleegers
            double doubleMult = 6.69 * 45.58;
            // Initislized an doubleeger that adds to doubleegers
            double doubleAdd = 55.48 + 66.15;
            // Prints the maximum and minimum of the two doubleeger varibles
            Console.WriteLine($"The max of {doubleMult} and {doubleAdd} is{Math.Max(doubleMult, doubleAdd)}. " +
                $"The min  of the two is {Math.Min(doubleMult, doubleAdd)}.");
            // initializes boolean to see if doubleMult is greater than doubleAdd
            bool isdoubleGreater = doubleMult > doubleAdd;
            // prints if doubleMult is greater than doubleAdd
            Console.WriteLine($"{doubleMult} is greater than {doubleAdd}, {isdoubleGreater}.");
        }
    }
}
            // Initializes an decimaleger that multiplies two decimalegers
            decimal decimalMult = (decimal)(6.25 * 45.15);
            // Initislized an decimaleger that adds to decimalegers
           decimal decimalAdd = (decimal)(55.66 + 66.55);
            // Prdecimals the maximum and minimum of the two decimaleger varibles
            Console.WriteLine($"The max of {decimalMult} and {decimalAdd} is{Math.Max(decimalMult, decimalAdd)}. " +
                $"The min  of the two is {Math.Min(decimalMult, decimalAdd)}.");
            // initializes boolean to see if decimalMult is greater than decimalAdd
            bool isdecimalGreater = decimalMult > decimalAdd;
            // prints if decimalMult is greater than decimalAdd
            Console.WriteLine($"{decimalMult} is greater than {decimalAdd}, {isdecimalGreater}.");

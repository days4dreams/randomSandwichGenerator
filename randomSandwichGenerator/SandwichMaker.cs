using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomSandwichGenerator
{
    class SandwichMaker
    {
        public Random Randomizer;
        //ref to the Random object from .NET Framework. Will use Next() method to generate random nos.

        string[] Meats = { "Roast Beef", "Salami", "Turkey", "Ham", "Pastrami" };
        //create an array object of type string. Hold filling options
        string[] Condiments = { "yello mustard", "brown sauce", "honey mustard", "mayo", "relish", "french dressing" };
        string[] Breads = { "rye", "white", "wheat", "pumpernickle", "italian bread", "a roll" };

        public string GetMenuItem()
        {
            string randomMeat = Meats[Randomizer.Next(Meats.Length)];
            string randomCondiment = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBread = Breads[Randomizer.Next(Condiments.Length)];
            return randomMeat + " with " + randomCondiment + " on " + randomBread;
        }

        //a method which returns a string built from random elements in the arrays
        //puts a random item from the Meats array into randomMeat by passing Meats.Length to the Random object's Next() method
        //Next(5) returns random number between 0 and 4 (zero based); we pass it the value using .Length
    }
}

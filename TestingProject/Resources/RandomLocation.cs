using System;
using System.Collections.Generic;

namespace Selenium
{
    public class RandomLocation
    {
        Random rand = new Random();
        //public string[] RandomList = new string[5]; 
        public List<string> RandomList = new List<string>();

        public RandomLocation() //constructor, but a more classic usage
        {
            RandomList[0] = Constants.Names[rand.Next(0, Constants.Names.Length)];
            RandomList[1] = Constants.Address1[rand.Next(0, Constants.Address1.Length)];
            RandomList[2] = Constants.Address2[rand.Next(0, Constants.Address2.Length)];
            RandomList[3] = Constants.CityBlocks[rand.Next(0, 1)][5]; //This needs to do something different. This works for the one usecase on the loadform, and that's it
        }

    }
}

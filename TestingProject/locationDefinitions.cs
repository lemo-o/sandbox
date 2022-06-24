using System;

namespace seleniumtest
{
	public class generalDefinitions
	{
		public string[] names = //I guess I could also pull these from a file, but this is just as practical
		{
			"John Denver",
			"Lottery Winner",
			"Barrack Obama",
			"Donald Trump"
		};
		public string[] address1 =
		{
			"123 America Street",
			"9576 West W Emerald St", //Quality Logic Boise
			"4045 NW 64th St" //Quality Logic OKC
		};
		public string[] address2 =
		{
			"Suite 120",
			"Literally Words",
			"This can be anything"
		};
		//I have a feel ~may~ have to be a 3x3 array, or just done cleverly. At least the states have to be tied to zips, and then probably the cities too

		public string[5,] city_Blocks //two dimensional array to handle how locations are tied together - 0 is city, 1 is state, 2 is state abbreviation, 3 is country, 4 is country abbreviation, 5 is ZIP code
		{
            cityBlocks[0,0] = "Boise",
			cityBlocks[1,0] = "Idaho",
            cityBlocks[2,0] = "ID",
            cityBlocks [3,0] = "United States",
			cityBlocks [4,0] = "US",
			cityBlocks [5,0] = "83701",

            cityBlocks [0,1] =  "Oklahoma City",
			cityBlocks [1,1] =  "Oklahoma",
			cityBlocks [2,1] =  "OK",
			cityBlocks [3,1] =  "United States",
			cityBlocks [4,1] =  "US",
			cityBlocks [5,1] =  "73116",
		}; //If I was doing more than two locations, I would make this loop in such a way that I can enter: "Boise", "Idaho", "ID", "United States", "US", "83701" and let a function handle it

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumTest
{
		public class locationDefinitions
		{
			Random rand = new Random();
			public string[] randomizedItems = new string[5]; // this should "interface" better - maybe use something like the factory method? Is this the factory method? I don't knwo, I need to look hahaha

			public locationDefinitions() //constructor, but a more classic usage
			{
			randomizedItems[0] = names[rand.Next(0, names.Length)];
			randomizedItems[1] = address1[rand.Next(0, address1.Length)];
			randomizedItems[2] = address2[rand.Next(0, address2.Length)];
			randomizedItems[3] = city_Blocks[rand.Next(0, 1)][5]; //This needs to do something different. This works for the one usecase on the loadform, and that's it
			}

			private string[] names = //I guess I could also pull these from a file, but this is just as practical. and I also guess these should be ~place~ names but this doesn't matter too much. A string is a string                   -usually
			{
			"John Denver",
			"Lottery Winner",
			"Jessie Dean",
			"Aisha Mathews",
			"Traci Sawyer",
			"Taran Chandler",
			"Clarence Henderson",
			"Zahra Curry",
			"Millie-Rose Pruitt"
			};
			private string[] address1 =
			{
			"123 America Street",
			"9576 West W Emerald St", //Quality Logic Boise
			"4045 NW 64th St" //Quality Logic OKC
			};
			private string[] address2 =
			{
			"Suite 120",
			"Literally Words",
			"This can be anything"
			};
		//I have a feel ~may~ have to be a 3x3 array, or just done cleverly. At least the states have to be tied to zips, and then probably the cities too

		private string[][] city_Blocks = new string[][]{
                new string[]
				{              
				"Boise",
				"Idaho",
				"ID",
				"United States",
				"US",
				"83701"
				},

				new string[]
                {
				"Oklahoma City",
				"Oklahoma",
				"OK",
				"United States",
				"US",
				"73116"
				}

			};

//If I was doing more than two locations, I would make this loop in such a way that I can enter: "Boise", "Idaho", "ID", "United States", "US", "83701" and let a function handle it

		}
}

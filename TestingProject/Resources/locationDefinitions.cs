using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumTest
{
		public class LocationDefinitions
		{
			Random rand = new Random();
			public string[] RandomizedItems = new string[5]; // this should "interface" better - maybe use something like the factory method? Is this the factory method? I don't knwo, I need to look hahaha

			public LocationDefinitions() //constructor, but a more classic usage
			{
			RandomizedItems[0] = _names[rand.Next(0, _names.Length)];
			RandomizedItems[1] = _address1[rand.Next(0, _address1.Length)];
			RandomizedItems[2] = _address2[rand.Next(0, _address2.Length)];
			RandomizedItems[3] = _cityBlocks[rand.Next(0, 1)][5]; //This needs to do something different. This works for the one usecase on the loadform, and that's it
			}

			private string[] _names = //I guess I could also pull these from a file, but this is just as practical. and I also guess these should be ~place~ _names but this doesn't matter too much. A string is a string                   -usually
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

			private string[] _address1 =
			{
			"123 America Street",
			"9576 West W Emerald St", //Quality Logic Boise
			"4045 NW 64th St" //Quality Logic OKC
			};

			private string[] _address2 =
			{
			"Suite 120",
			"Literally Words",
			"This can be anything"
			};

			private string[][] _cityBlocks = new string[][]{ //If I was doing more than two locations, I would make this loop in such a way that I can enter: "Boise", "Idaho", "ID", "United States", "US", "83701" and let a function handle it
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
		}
}

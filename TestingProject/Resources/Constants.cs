namespace Selenium
{
    public class Constants
    {
        public static string[] Names =
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

        public static string[] Address1 =
        {
            "123 America Street",
            "9576 West W Emerald St", //Quality Logic Boise
			"4045 NW 64th St" //Quality Logic OKC
		};

        public static string[] Address2 =
        {
            "Suite 120",
            "Literally Words",
            "This can be anything"
        };

        public static string[][] CityBlocks = new string[][]
        {
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
        public static string[] URLs =
        {
            "https://brokerage.qc.suntecktts.com/agents/login", //qc environment login
			"https://brokerage.stage.suntecktts.com/agents/login", //staging environment login 
            "https://brokerage.qc.suntecktts.com/web/home", //QC Homepage
            "https://brokerage.qc.suntecktts.com/web/loads/new", //QC CreateTL
            "https://brokerage.stage.suntecktts.com/web/home"
        };
        public static string[] Usernames =
        {
            "ben.hall"
        };
        public static string[] Passwords =
        {
            "Qll2mm.08"
        };
    }
}
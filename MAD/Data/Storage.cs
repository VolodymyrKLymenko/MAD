namespace MAD.Data
{
    public static class Storage
    {
        public static string[] Alternatives = new string[] {
            "Money diff",
            "Middle Age diff",
            "Total Wins Percent diff",
            "Coach Experiance",
            "Funs amount diff",
            "Appsend players amount",
            "Bet koef"
        };
        
        // For Display
        public static string[] AlternativeshortName = new string[] {
            "MoneyDiff",
            "MiddleAge",
            "TotalWins",
            "CoachExpe",
            "FunsAmoun",
            "AppsendPl",
            "Bet  koef"
        };

        public static string[] Choices = new string[]
        {
            "Karpaty",
            "Dynamo",
            "Liverpool",
            "Dynamo"
        };

        public static double[,] AlternativeComparionMatrix;


        static Storage()
        {
            AlternativeComparionMatrix = new double[Alternatives.Length, Alternatives.Length];
        }
    }
}

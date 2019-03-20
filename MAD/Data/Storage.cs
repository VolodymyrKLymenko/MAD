namespace MAD.Data
{
    public static class Storage
    {
        public static string[] Kriteries = new string[] {
            "Money diff",
            "Middle Age diff",
            "Total Wins Percent diff",
            "Coach Experiance",
            "Funs amount diff",
            "Appsend players amount",
            "Bet koef"
        };
        
        // For Display
        public static string[] KriteriesShortName = new string[] {
            "MoneyDiff",
            "MiddleAge",
            "TotalWins",
            "CoachExpe",
            "FunsAmoun",
            "AppsendPl",
            "Bet  koef"
        };

        public static string[] _Alternatives = new string[]
        {
            "Karpaty",
            "Dynamo",
            "Liverpool",
            "Dynamo"
        };

        public static double[,] KriteriesComparionMatrix;


        static Storage()
        {
            KriteriesComparionMatrix = new double[Kriteries.Length, Kriteries.Length];
        }
    }
}

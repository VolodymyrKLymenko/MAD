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

        public static string[] Alternatives = new string[]
        {
            "Karpaty",
            "Dynamo",
            "Liverpool",
            "Dynamo"
        };

        // For Display
        public static string[] AlternativeshortNames = new string[]
        {
            "Karpaty  ",
            "Dynamo   ",
            "Liverp   ",
            "Real     "
        };


        public static double[,] KriteriesComparionMatrix;

        public static double[,] CompareAlternativeByMoney;
        public static double[,] CompareAlternativeByAge;
        public static double[,] CompareAlternativeByTotalWins;
        public static double[,] CompareAlternativeByExperiance;
        public static double[,] CompareAlternativeByFuns;
        public static double[,] CompareAlternativeByAppsend;
        public static double[,] CompareAlternativeByBetKoef;


        static Storage()
        {
            KriteriesComparionMatrix = new double[Kriteries.Length, Kriteries.Length];
            CompareAlternativeByMoney = new double[Alternatives.Length, Alternatives.Length];
            CompareAlternativeByAge = new double[Alternatives.Length, Alternatives.Length];
            CompareAlternativeByTotalWins = new double[Alternatives.Length, Alternatives.Length];
            CompareAlternativeByExperiance = new double[Alternatives.Length, Alternatives.Length];
            CompareAlternativeByFuns = new double[Alternatives.Length, Alternatives.Length];
            CompareAlternativeByAppsend = new double[Alternatives.Length, Alternatives.Length];
            CompareAlternativeByBetKoef = new double[Alternatives.Length, Alternatives.Length];
        }
    }
}

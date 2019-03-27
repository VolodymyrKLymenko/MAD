
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

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
            "Real"
        };

        // For Display
        public static string[] AlternativeshortNames = new string[]
        {
            "Karpaty  ",
            "Dynamo   ",
            "Liverp   ",
            "Real     "
        };

        public static Vector<double> CustomVector = DenseVector.Create(Kriteries.Length, 0);
        public static Vector<double> EstimatedAlternatives = DenseVector.Create(Alternatives.Length, 0);

        public static double[,] KriteriesComparionMatrix =
        {
            { 5, 0.34, 7, 0.54, 10, 7, 1 },
            { 4, 8, 7, 0.54, 10, 7, 2 },
            { 5, 0.34, 7, 0.54, 10, 1.7, 2 },
            { 5, 0.34, 0.7, 0.54, 10, 7, 2 },
            { 15, 0.34, 7, 0.54, 10, 7, 3.2 },
            { 5, 0.34, 7, 0.54, 3, 7, 2 },
            { 5, 0.34, 7, 0.54, 10, 7, 2 }
        };

        public static double[,] CompareAlternativeByMoney =
        {
            { 5, 3, 4, 0.7 },
            { 0.5, 7, 14, 0.3 },
            { 5.1, 7, 4, 0.3 },
            { 5, 7.2, 4.8, 0.3 }
        };
        public static double[,] CompareAlternativeByAge =
        {
            { 5, 7, 8, 0.1 },
            { 2, 9, 4, 0.3 },
            { 5, 7, 14, 0.8 },
            { 3, 0.7, 4, 0.3 }
        };
        public static double[,] CompareAlternativeByTotalWins =
        {
            { 5, 7, 4.8, 0.3 },
            { 15, 7, 4, 0.3 },
            { 5, 7, 4.2, 0.3 },
            { 2.5, 7, 4, 0.3 }
        };
        public static double[,] CompareAlternativeByExperiance =
        {
            { 5, 7, 4, 0.3 },
            { 5, 7, 4, 0.3 },
            { 5, 7, 4, 0.3 },
            { 5, 7, 4, 0.3 }
        };
        public static double[,] CompareAlternativeByFuns =
        {
            { 5, 9.7, 4, 0.3 },
            { 7, 7, 8, 0.3 },
            { 5, 9.17, 2, 0.3 },
            { 1, 7, 3, 0.3 }
        };
        public static double[,] CompareAlternativeByAppsend =
        {
            { 5, 1.7, 4, 1.3 },
            { 4, 7, 14, 0.3 },
            { 5, 9.7, 4, 9.3 },
            { 9, 7, 4, 0.3 }
        };
        public static double[,] CompareAlternativeByBetKoef =
        {
            { 4, 7, 4, 3.3 },
            { 5, 8, 4, 0.3 },
            { 3, 7, 4, 1.3 },
            { 5, 0.7, 4, 0.3 }
        };

        public static double[,] CompareAlternativesKriteries;


        static Storage()
        {
            CompareAlternativesKriteries = new double[Alternatives.Length, Kriteries.Length];
        }
    }
}

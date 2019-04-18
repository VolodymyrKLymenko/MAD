
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
            "Liverpool",
            "Ajax",
            "Barcelona",
            "Totenham"
        };

        // For Display
        public static string[] AlternativeshortNames = new string[]
        {
            "Livarpool",
            "Ajax     ",
            "Barcelona",
            "Totenham "
        };

        public static Vector<double> CustomVector = DenseVector.Create(Kriteries.Length, 0);
        public static Vector<double> EstimatedAlternatives = DenseVector.Create(Alternatives.Length, 0);

        // in range [1 - 9]
        public static double[,] KriteriesComparionMatrix =
        {
            { 1,      (1/8),       2, (1/2), (1/9),  (1/7),  (1/3)    },
            { 8,          1,       5,     6,     3,      2,      9    },
            { (1/2),  (1/5),       1,     5,     8,      5,   (1/2)   },
            { 2,      (1/6),   (1/5),     1, (1/4),  (1/2),   (1/7)   },
            { 9,      (1/3),   (1/8),     4,     1,      2,      1,   },
            { 7,      (1/2),   (1/5),     2, (1/2),      1,   (1/3),  },
            { 3,      (1/9),       2,     7,     1,      3,      1,   }
        };

        public static double[,] CompareAlternativeByMoney =
        {
            { 1,         3,        2,    (1/5) },
            { (1/3),     1,        1,      2   },
            { (1/2), (1/4),        1,   (1/5)  },
            { 5,         1,        5,     1    }
        };
        public static double[,] CompareAlternativeByAge =
        {
            { 1,         4,    (1/2),    (1/3) },
            { (1/4),     1,        1,      2   },
            { 2,     (1/4),        1,      4   },
            { 3,         1,    (1/4),      1   }
        };
        public static double[,] CompareAlternativeByTotalWins =
        {
            { 1,     (1/2),        2,    (1/4) },
            { 2,         1,        1,      2   },
            { (1/2), (1/4),        1,      8   },
            { 4,         1,    (1/8),      1   }
        };
        public static double[,] CompareAlternativeByExperiance =
        {
            { 1,     (1/2),        2,      1   },
            { 2,         1,        1,      2   },
            { (1/2), (1/4),        1,    (1/9) },
            { 1,         1,        9,      1   }
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


using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace MAD.Data
{
    public static class Storage
    {
        public static string[] Kriteries = new string[] {
            "Middle Age diff",
            "Money diff",
            "Total Wins Percent diff",
            "Coach Experiance",
            "Funs amount diff",
            "Appsend players amount"
        };
        
        // For Display
        public static string[] KriteriesShortName = new string[] {
            "MiddleAge",
            "MoneyDiff",
            "TotalWins",
            "CoachExpe",
            "FunsAmoun",
            "AppsendPl"
        };

        public static string[] Alternatives = new string[]
        {
            "Barcelona",
            "Totenham",
            "Ajax",
            "Liverpool"
        };

        // For Display
        public static string[] AlternativeshortNames = new string[]
        {
            "Barcelona",
            "Totenham ",
            "Ajax     ",
            "Livarpool"
        };

        public static Vector<double> CustomVector = DenseVector.Create(Kriteries.Length, 0);
        public static Vector<double> EstimatedAlternatives = DenseVector.Create(Alternatives.Length, 0);

        // in range [1 - 9]
        public static double[,] KriteriesComparionMatrix =
        {
            { (double)1,      ((double)1/8),       (double)2, ((double)1/2), ((double)1/9),  ((double)1/7)  },
            {(double) 8,          (double)1,       (double)5,     (double)6,     (double)3,      (double)2  },
            { ((double)1/2),  ((double)1/5),       (double)1,     (double)5,     (double)8,      (double)5  },
            { (double)2,      ((double)1/6),   ((double)1/5),     (double)1, ((double)1/4),  ((double)1/2)  },
            { (double)9,      ((double)1/3),   ((double)1/8),     (double)4,     (double)1,      (double)2  },
            { (double)7,      ((double)1/2),   ((double)1/5),     (double)2, ((double)1/2),      (double)1  }
        };

        public static double[,] CompareAlternativeByMoney =
        {
            { (double)1,         (double)3,        (double)2,    ((double)1/5) },
            { ((double)1/3),     (double)1,        (double)1,      (double)2   },
            { ((double)1/2), ((double)1/4),        (double)1,   ((double)1/5)  },
            { (double)5,         (double)1,        (double)5,     (double)1    }
        };
        public static double[,] CompareAlternativeByAge =
        {
            { (double)1,         (double)4,    ((double)1/2),    ((double)1/3) },
            { ((double)1/4),     (double)1,        (double)1,      (double)2   },
            { (double)2,     ((double)1/4),        (double)1,      (double)4   },
            { (double)3,         (double)1,    ((double)1/4),      (double)1   }
        };
        public static double[,] CompareAlternativeByTotalWins =
        {
            { (double)1,     ((double)1/2),        (double)2,    ((double)1/4) },
            { (double)2,         (double)1,        (double)1,      (double)2   },
            { ((double)1/2), ((double)1/4),        (double)1,      (double)8   },
            { (double)4,         (double)1,    ((double)1/8),      (double)1   }
        };
        public static double[,] CompareAlternativeByExperiance =
        {
            { (double)1,     ((double)1/2),        (double)2,      (double)1   },
            { (double)2,         (double)1,        (double)1,      (double)2   },
            { ((double)1/2), ((double)1/4),        (double)1,    ((double)1/9) },
            { (double)1,     ((double)1/2),        (double)9,      (double)1   }
        };
        public static double[,] CompareAlternativeByFuns =
        {
            { (double)1,       ((double)5),      ((double)3),      (double)1   },
            { ((double)1/5),     (double)1,    ((double)1/2),  ((double)1/2)   },
            { ((double)1/3),     (double)2,        (double)1,    ((double)1/3) },
            { (double)1,         (double)2,        (double)3,      (double)1   }
        };
        public static double[,] CompareAlternativeByAppsend =
        {
            { (double)1,       ((double)2),      ((double)1),      (double)1   },
            { ((double)1/2),     (double)1,    ((double)1/2),  ((double)1/2)   },
            { ((double)1),       (double)2,        (double)1,    ((double)1/3) },
            { (double)1,         (double)2,        (double)3,      (double)1   }
        };

        public static double[,] CompareAlternativesKriteries;


        static Storage()
        {
            CompareAlternativesKriteries = new double[Alternatives.Length, Kriteries.Length];
        }
    }
}

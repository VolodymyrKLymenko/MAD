using MAD.Common;
using MAD.Data;
using System;

namespace MAD.Interface
{
    public static class Start
    {
        public static void SayHi()
        {
            Console.WriteLine("Hi! Today is boxing day");
            Console.WriteLine(" Karpaty vs Dynamo");
            Console.WriteLine(" Liverpool vs Real");
            Console.WriteLine("Who win?\n");
        }

        public static void InitializeKriterie()
        {
            Console.WriteLine("\nCompare by pairs: ");
            Console.WriteLine("If compare A vs B then\n if mark for A is 5 then for B is 1/5\n");

            CompareMatrixValues(Storage.Kriteries, ref Storage.KriteriesComparionMatrix);
        }

        public static void InitializeCriteriesImportances()
        {
            Console.WriteLine("\nSet your priorities: ");
            Console.WriteLine("If compare A vs B then\n if mark for A is 5 then for B is 1/5\n");

            Console.WriteLine("Compare by MONEY:");
            CompareMatrixValues(Storage.Alternatives, ref Storage.CompareAlternativeByMoney);
            Console.WriteLine();

            Console.WriteLine("Compare by AGE:");
            CompareMatrixValues(Storage.Alternatives, ref Storage.CompareAlternativeByAge);
            Console.WriteLine();

            Console.WriteLine("Compare by APPEND PLAYER:");
            CompareMatrixValues(Storage.Alternatives, ref Storage.CompareAlternativeByAppsend);
            Console.WriteLine();

            Console.WriteLine("Compare by BET KOEF:");
            CompareMatrixValues(Storage.Alternatives, ref Storage.CompareAlternativeByBetKoef);
            Console.WriteLine();

            Console.WriteLine("Compare by EXPERIANCE:");
            CompareMatrixValues(Storage.Alternatives, ref Storage.CompareAlternativeByExperiance);
            Console.WriteLine();

            Console.WriteLine("Compare by FUNS SUPPORT:");
            CompareMatrixValues(Storage.Alternatives, ref Storage.CompareAlternativeByFuns);
            Console.WriteLine();

            Console.WriteLine("Compare by TOTAL WINS:");
            CompareMatrixValues(Storage.Alternatives, ref Storage.CompareAlternativeByTotalWins);
            Console.WriteLine();
        }

        public static bool ChooseWay(string msg = "")
        {
            Console.WriteLine(msg);
            Console.WriteLine("y - for YES");
            Console.WriteLine("n - for NO");
            Console.WriteLine("other - for NO");

            var answer = Console.ReadLine();
            return answer == "y" || answer == "Y";
        }

        private static void CompareMatrixValues(string[] values, ref double[,] resMatrix)
        {
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = i; j < values.Length; j++)
                {
                    if (i != j)
                    {
                        while (true)
                        {
                            Console.Write($"Compare {values[i]} vs {values[j]} ");
                            var value = CommonInput.Input<double>(-1);

                            if (value < 0) continue;

                            resMatrix[i, j] = value;
                            resMatrix[j, i] = 1 / value;
                            Console.WriteLine();
                            break;
                        }
                    }
                    else
                    {
                        resMatrix[i, j] = 1;
                    }
                }
            }
        }
    }
}

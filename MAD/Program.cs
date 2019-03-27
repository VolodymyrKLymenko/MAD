using MAD.Core;
using MAD.Data;
using MAD.Interface;

namespace MAD
{
    class Program
    {
        static void Main(string[] args)
        {
            Start.SayHi();
            var choseCustomWay = Start.ChooseWay("Initialize custom (y/n):");
            if (choseCustomWay)
            {
                Start.InitializeKriterie();
            }
            Print.PrintAlternativeComparionMatrix();

            Storage.CustomVector = Calculation.CalculateCustomVectorOfMatrix(Storage.KriteriesComparionMatrix);
            Print.PrintVector(Storage.CustomVector, "Custom vector: ");

            if (choseCustomWay)
            {
                Start.InitializeCriteriesImportances();
            }
            Print.PrintKriteriesComparisonMatrix(Storage.CompareAlternativeByAge, "Age");
            Print.PrintKriteriesComparisonMatrix(Storage.CompareAlternativeByAppsend, "Appsend player");
            Print.PrintKriteriesComparisonMatrix(Storage.CompareAlternativeByBetKoef, "Bet koef");
            Print.PrintKriteriesComparisonMatrix(Storage.CompareAlternativeByExperiance, "Experiance");
            Print.PrintKriteriesComparisonMatrix(Storage.CompareAlternativeByMoney, "Money");
            Print.PrintKriteriesComparisonMatrix(Storage.CompareAlternativeByFuns, "Funs Support");
            Print.PrintKriteriesComparisonMatrix(Storage.CompareAlternativeByTotalWins, "Total win");

            Calculation.CalculateComparionMatrix();
            Print.PrintKriteriesAlternativesComparisonMatrix(
                "По каждому критерию рассчитывается собственный вектор и отношение согласованности." +
                "\nПолученные собственные векторы записаны в столбцах:\n");

            Calculation.CalculateEstimationVector();
            Print.PrintEstimatedValues();

            Finish.FinishTask();
        }
    }
}

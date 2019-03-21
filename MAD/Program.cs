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
            Start.InitializeKriterie();

            
            Print.PrintAlternativeComparionMatrix();

            var customVector = Calculation.CalculateCustomVectorOfMatrix(Storage.KriteriesComparionMatrix);
            System.Console.WriteLine("Custom vector: ");
            Print.PrintVector(customVector);

            Start.InitializeCriteriesImportances();
            Print.PrintKriteriesComparisonMatrix(Storage.CompareAlternativeByAge, "Age");
            Print.PrintKriteriesComparisonMatrix(Storage.CompareAlternativeByAppsend, "Appsend player");
            Print.PrintKriteriesComparisonMatrix(Storage.CompareAlternativeByBetKoef, "Bet koef");
            Print.PrintKriteriesComparisonMatrix(Storage.CompareAlternativeByExperiance, "Experiance");
            Print.PrintKriteriesComparisonMatrix(Storage.CompareAlternativeByMoney, "Money");
            Print.PrintKriteriesComparisonMatrix(Storage.CompareAlternativeByFuns, "Funs Support");
            Print.PrintKriteriesComparisonMatrix(Storage.CompareAlternativeByTotalWins, "Total win");

            Finish.FinishTask();
        }
    }
}

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
            Start.InitializeAlternatives();

            
            Print.PrintAlternativeComparionMatrix();

            var customVector = Calculation.CalculateCustomVectorOfMatrix(Storage.AlternativeComparionMatrix);
            System.Console.WriteLine("Custom vector: ");
            Print.PrintVector(customVector);

            Finish.FinishTask();
        }
    }
}

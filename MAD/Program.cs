using MAD.Interface;

namespace MAD
{
    class Program
    {
        static void Main(string[] args)
        {
            Start.SayHi();
            Start.InitializeAlternatives();

            Finish.FinishTask();
        }
    }
}

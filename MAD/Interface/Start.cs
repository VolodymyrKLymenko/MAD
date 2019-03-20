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

        public static void InitializeAlternatives()
        {
            Console.WriteLine("\nCompare by pairs: ");
            Console.WriteLine("If compare A vs B then\n if mark for A is 5 then for B is 1/5\n");

            for (int i = 0; i < Storage.Alternatives.Length; i++)
            {
                for (int j = i; j < Storage.Alternatives.Length; j++)
                {
                    if (i != j)
                    {
                        while (true)
                        {
                            Console.Write($"Compare {Storage.Alternatives[i]} vs {Storage.Alternatives[j]} ");
                            var value = CommonInput.Input<float>(-1);

                            if (value < 0) continue;

                            Storage.AlternativeComparionMatrix[i][j] = value;
                            Storage.AlternativeComparionMatrix[j][i] = 1 / value;
                            Console.WriteLine();
                            var res2 = Storage.AlternativeComparionMatrix;
                            break;
                        }
                    }
                    else
                    {
                        Storage.AlternativeComparionMatrix[i][j] = 1;
                    }
                }
            }

            var res = Storage.AlternativeComparionMatrix;
        }
    }
}

using MAD.Data;
using System;

namespace MAD.Core
{
    public static class Print
    {
        public static void PrintAlternativeComparionMatrix()
        {
            for (int i = 0; i < Storage.AlternativeComparionMatrix.Length; i++)
            {
                for (int j = 0; j < Storage.AlternativeComparionMatrix.Length; j++)
                {
                    Console.Write($"[{ Storage.AlternativeComparionMatrix[i][j]:00.0000}] ");
                }
                Console.WriteLine();
            }
        }
    }
}

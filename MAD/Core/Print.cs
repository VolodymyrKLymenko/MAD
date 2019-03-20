using MAD.Data;
using MathNet.Numerics.LinearAlgebra;
using System;

namespace MAD.Core
{
    public static class Print
    {
        public static void PrintAlternativeComparionMatrix()
        {
            Console.Write("         ");
            foreach (var item in Storage.KriteriesShortName)
            {
                Console.Write($" {item}");
            }
            Console.WriteLine();
            for (int i = 0; i < Storage.KriteriesComparionMatrix.GetLength(0); i++)
            {
                Console.Write($"{Storage.KriteriesShortName[i]} ");
                for (int j = 0; j < Storage.KriteriesComparionMatrix.GetLength(0); j++)
                {
                    Console.Write($"[{ Storage.KriteriesComparionMatrix[i, j]:00.0000}] ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintVector(Vector<double> vector)
        {
            foreach (var item in vector)
            {
                Console.Write($"{item:.####} ");
            }
            Console.WriteLine();
        }
    }
}

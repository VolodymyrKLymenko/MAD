using MAD.Data;
using MathNet.Numerics.LinearAlgebra;
using System;

namespace MAD.Core
{
    public static class Print
    {
        public static void PrintEstimatedValues()
        {
            Console.WriteLine("\nResult estimated alternatives values is:");

            for (int i = 0; i < Storage.AlternativeshortNames.Length; i++)
            {
                Console.WriteLine($"{Storage.Alternatives[i]}: {Storage.EstimatedAlternatives[i]:0.####}");
            }

            Console.WriteLine();
        }

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

        public static void PrintKriteriesComparisonMatrix(double[,] alternativesMatrix, string mesage = "")
        {
            Console.WriteLine($"Compare by {mesage}");
            Console.Write("         ");
            foreach (var item in Storage.AlternativeshortNames)
            {
                Console.Write($" {item}");
            }
            Console.WriteLine();
            for (int i = 0; i < alternativesMatrix.GetLength(0); i++)
            {
                Console.Write($"{Storage.AlternativeshortNames[i]} ");
                for (int j = 0; j < alternativesMatrix.GetLength(1); j++)
                {
                    Console.Write($"[{ alternativesMatrix[i, j]:00.0000}] ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintKriteriesAlternativesComparisonMatrix(string mesage = "")
        {
            Console.WriteLine($"{mesage}");
            Console.Write("         ");
            var str = Storage.CompareAlternativesKriteries;
            var x = Storage.CompareAlternativesKriteries.GetLength(0);
            var y = Storage.CompareAlternativesKriteries.GetLength(1);
            foreach (var item in Storage.KriteriesShortName)
            {
                Console.Write($" {item}");
            }
            Console.WriteLine();
            for (int i = 0; i < Storage.CompareAlternativesKriteries.GetLength(0); i++)
            {
                Console.Write($"{Storage.KriteriesShortName[i]} ");
                for (int j = 0; j < Storage.CompareAlternativesKriteries.GetLength(1); j++)
                {
                    Console.Write($"[{ Storage.CompareAlternativesKriteries[i, j]:00.0000}] ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintVector(Vector<double> vector, string msg)
        {
            Console.WriteLine($"{msg}:");
            Console.Write("\n[");
            foreach (var item in vector)
            {
                Console.Write($"{item:##.####}, ");
            }
            Console.WriteLine("]\n");
        }
    }
}

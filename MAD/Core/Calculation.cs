using MAD.Data;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
using System;

namespace MAD.Core
{
    public static class Calculation
    {
        public const double PRECISION = 0.001;
        public const int MAX_ITERATIONS = 10000000;

        public static void CalculateEstimationVector()
        {
            Matrix<double> customMatrix = Matrix.Build.DenseOfArray(Storage.CompareAlternativesKriteries);
            Storage.EstimatedAlternatives = customMatrix * Storage.CustomVector;
        }

        public static Vector<double> CalculateCustomVectorOfMatrix(double[,] matrix)
        {
            Matrix<double> numMatrix = Matrix.Build.DenseOfArray(matrix);

            Vector<double> x = DenseVector.Create(matrix.GetLength(0), (double)((double)1 / (double)matrix.GetLength(0)));
            double curEigenvalue = 0;
            double prevEigenvalue = 0;
            for (int i = 0; i < 2 || Math.Abs(curEigenvalue - prevEigenvalue) > PRECISION; i++)
            {
                if (i >= MAX_ITERATIONS)
                {
                    throw new Exception($"Eigenvector was not found after %d iterations: {MAX_ITERATIONS}");
                }
                var Y = numMatrix * x;
                prevEigenvalue = curEigenvalue;
                curEigenvalue = Y.Sum();
                x = Y.Divide(curEigenvalue);
            }
            var eigenvector = x;
            var eigenvalue = curEigenvalue;

            return x;
        }

        public static void CalculateComparionMatrix()
        {
            var eigenByAge = CalculateCustomVectorOfMatrix(Storage.CompareAlternativeByAge);
            var eigenByApsend = CalculateCustomVectorOfMatrix(Storage.CompareAlternativeByAppsend);
            var eigenByBetKoef = CalculateCustomVectorOfMatrix(Storage.CompareAlternativeByBetKoef);
            var eigenByExperience = CalculateCustomVectorOfMatrix(Storage.CompareAlternativeByExperiance);
            var eigenByFuns = CalculateCustomVectorOfMatrix(Storage.CompareAlternativeByFuns);
            var eigenByMoney = CalculateCustomVectorOfMatrix(Storage.CompareAlternativeByMoney);
            var eigenByTotalWins = CalculateCustomVectorOfMatrix(Storage.CompareAlternativeByTotalWins);

            SetComparisonColumn(0, eigenByAge);
            SetComparisonColumn(1, eigenByApsend);
            SetComparisonColumn(2, eigenByBetKoef);
            SetComparisonColumn(3, eigenByExperience);
            SetComparisonColumn(4, eigenByFuns);
            SetComparisonColumn(5, eigenByMoney);
            SetComparisonColumn(6, eigenByTotalWins);

        }

        private static void SetComparisonColumn(int indexColumn, Vector<double> data)
        {
            for (int i = 0; i < data.Count; i++)
            {
                Storage.CompareAlternativesKriteries[i, indexColumn] = data[i];
            }
        }
    }
}

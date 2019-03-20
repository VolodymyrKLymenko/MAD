using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
using System;

namespace MAD.Core
{
    public static class Calculation
    {
        public const double PRECISION = 0.001;
        public const int MAX_ITERATIONS = 10000000;

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
    }
}

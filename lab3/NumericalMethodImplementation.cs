using System;
using System.Collections.Generic;
using System.Linq;

namespace lab3
{
    public class NumericalMethodImplementation
    {
        private double _aBound1;

        private double _aBound2;
        private double _bBound1;
        private double _bBound2;
        public List<(double, double)> Series1;
        public List<(double, double)> Series2;
        public double Epsilon { get; set; }
        private const double _h = 0.01;
        public (double, double) ApproximateRoot { get; set; }

        public double ABound1
        {
            get => _aBound1;
            set
            {
                if (_bBound1 < value)
                {
                    _aBound1 = _bBound1;
                    _bBound1 = value;
                }
                else
                {
                    _aBound1 = value;
                }
            }
        }

        public double BBound1
        {
            get => _bBound1;
            set
            {
                if (_aBound1 > value)
                {
                    _bBound1 = ABound1;
                    _aBound1 = value;
                }
                else
                {
                    _bBound1 = value;
                }
            }
        }

        public double ABound2
        {
            get => _aBound2;
            set
            {
                if (_bBound2 < value)
                {
                    _aBound2 = _bBound2;
                    _bBound2 = value;
                }
                else
                {
                    _aBound2 = value;
                }
            }
        }

        public double BBound2
        {
            get => _bBound2;
            set
            {
                if (_aBound2 > value)
                {
                    _bBound2 = ABound2;
                    _aBound2 = value;
                }
                else
                {
                    _bBound2 = value;
                }
            }
        }


        private double F1(double x1, double x2)
        {
            return Math.Sin(Math.Sin(x1 + 1)) - x2 - 1.2d;
        }

        private double F2(double x1, double x2)
        {
            return 2d * x1 + Math.Cos(Math.Cos(x2)) - 2d;
        }

        #region Jacoby

        public double F1DerivativeByX1(double x1, double x2)
        {
            return Math.Cos(x1 + 1d) * Math.Cos(Math.Sin(x1 + 1d));
        }

        public double F1DerivativeByX2(double x1, double x2)
        {
            return -1;
        }
        
        public double F2DerivativeByX1(double x1, double x2)
        {
            return 2;
        }

        public double F2DerivativeByX2(double x1, double x2)
        {
            return Math.Sin(x2) * Math.Sin(Math.Cos(x2));
        }
        
        private double[,] JacobyMatrix(double[] x)
        {
            var result = new[,]
            {
                {F1DerivativeByX1(x[0], x[1]), F1DerivativeByX2(x[0], x[1])},
                {F2DerivativeByX1(x[0], x[1]), F2DerivativeByX2(x[0], x[1])}
            };
            return result;
        }

        #endregion

        private double[] InverseVectorByAdditionOperation(double[] x)
        {
            return x.Select(xi => xi * -1).ToArray();
        }

        private double[] MinusF(double[] x)
        {
            return InverseVectorByAdditionOperation(new[] {F1(x[0], x[1]), F2(x[0], x[1])});
        }

        private double[] GetNextX(double[] x)
        {
            var jacobyMatrix = JacobyMatrix(x);
            var free = MinusF(x);
            
            var delta = SolveLinearEquationsSystem(jacobyMatrix, free);

            var result = new double[x.Length];
            for (var i = 0; i < x.Length; i++) result[i] = x[i] + delta[i];
            return result;
        }

        private void FindApproximateRoot()
        {
            if (Series1 != null && Series2 != null)
            {
                var tmp = (-1d, -1d, item3: double.MaxValue);
                for (var i = 0; i < Math.Min(Series1.Count, Series2.Count); i++)
                {
                    var checkingPoint = Series1[i];
                    for (var j = 0; j < Math.Min(Series1.Count, Series2.Count); j++)
                    {
                        var deltaX = Math.Abs(checkingPoint.Item1 - Series2[j].Item2);
                        var deltaY = Math.Abs(checkingPoint.Item2 - Series2[j].Item1);

                        var distanceSquared = deltaX * deltaX + deltaY * deltaY;

                        var candidate = (checkingPoint.Item1, checkingPoint.Item2, distanceSquared);
                        if (i != 0 && j != 0 && candidate.distanceSquared < tmp.item3) tmp = candidate;
                    }
                }

                ApproximateRoot = (tmp.Item1, tmp.Item2);
            }
        }

        public List<Lab3ResultRow> NewtonMethod()
        {
            var error = double.MaxValue;
            FindApproximateRoot();
            var result = new List<Lab3ResultRow>();

            var oldX = new[] {ApproximateRoot.Item1, ApproximateRoot.Item2};
            while (error > Epsilon)
            {
                var newX = GetNextX(oldX);
                var minusF = MinusF(newX);
                error = Math.Sqrt(minusF.Select(fxi => fxi * fxi).Sum());

                var resultRow = new Lab3ResultRow
                {
                    ApproximateCoordinates = oldX,
                    ApproximatedCoordinates = newX,
                    NormOfApproximatedCoordinatesVector = Math.Sqrt(minusF.Select(xi => xi * xi).Sum())
                };

                result.Add(resultRow);

                oldX = newX;
            }

            return result;
        }

        #region Relations

        private double X2FromX1(double x1)
        {
            return Math.Sin(Math.Sin(x1 + 4)) - 1.2;
        }

        private double X1FromX2(double x2)
        {
            return 1 - Math.Cos(Math.Cos(x2)) / 2d;
        }

        public List<(double, double)> CalculateSeries1()
        {
            Series1 = new List<(double, double)>();
            var iterationCount = (int) ((BBound1 - ABound1) / _h) + 1;
            for (var i = 0; i < iterationCount; i++)
            {
                var x = ABound1 + (i + 1) * _h;
                var y = X2FromX1(x);
                Series1.Add((x, y));
            }

            return Series1;
        }

        public List<(double, double)> CalculateSeries2()
        {
            Series2 = new List<(double, double)>();
            var iterationCount = (int) ((BBound2 - ABound2) / _h) + 1;
            for (var i = 0; i < iterationCount; i++)
            {
                var x = ABound2 + (i + 1) * _h;
                var y = X1FromX2(x);
                Series2.Add((y, x));
            }

            return Series2;
        }

        #endregion
        
        #region SLAU
        public double[] SolveLinearEquationsSystem(double[,] aMatrix, double[] free)
        {
            var gaussArray = new double[free.Length][];
            for (int i = 0; i < free.Length; i++)
            {
                var gaussArrayRow = new double[free.Length + 1];
                for (int j = 0; j < free.Length; j++)
                {
                    gaussArrayRow[j] = aMatrix[i, j];
                }

                gaussArrayRow[free.Length] = free[i];
                gaussArray[i] = gaussArrayRow;
            }
            var result = SolveLinearEquations(gaussArray);
            return result;
        }

        private double[] SolveLinearEquations(double[][] rows)
        {
            var length = rows[0].Length;

            for (var i = 0; i < rows.Length - 1; i++)
            {
                if (rows[i][i] == 0 && !Swap(rows, i, i)) return null;

                for (var j = i; j < rows.Length; j++)
                {
                    var d = new double[length];
                    for (var x = 0; x < length; x++)
                    {
                        d[x] = rows[j][x];
                        if (rows[j][i] != 0) d[x] = d[x] / rows[j][i];
                    }

                    rows[j] = d;
                }

                for (var y = i + 1; y < rows.Length; y++)
                {
                    var f = new double[length];
                    for (var g = 0; g < length; g++)
                    {
                        f[g] = rows[y][g];
                        if (rows[y][i] != 0) f[g] = f[g] - rows[i][g];
                    }

                    rows[y] = f;
                }
            }

            return CalculateResult(rows);
        }

        private bool Swap(double[][] rows, int row, int column)
        {
            var swapped = false;
            for (var z = rows.Length - 1; z > row; z--)
                if (rows[z][row] != 0)
                {
                    var temp = rows[z];
                    rows[z] = rows[column];
                    rows[column] = temp;
                    swapped = true;
                }

            return swapped;
        }

        private double[] CalculateResult(double[][] rows)
        {
            double val = 0;
            var length = rows[0].Length;
            var result = new double[rows.Length];
            for (var i = rows.Length - 1; i >= 0; i--)
            {
                val = rows[i][length - 1];
                for (var x = length - 2; x > i - 1; x--) val -= rows[i][x] * result[x];
                result[i] = val / rows[i][i];

                if (!IsValidResult(result[i])) return null;
            }

            return result;
        }

        private bool IsValidResult(double result)
        {
            return !(double.IsNaN(result) || double.IsInfinity(result));
        }
        #endregion
    }

    public class Lab3ResultRow
    {
        public double[] ApproximateCoordinates { get; set; }
        public double[] ApproximatedCoordinates { get; set; }
        public double NormOfApproximatedCoordinatesVector { get; set; }
    }
}
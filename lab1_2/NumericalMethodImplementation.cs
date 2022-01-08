using System;
using System.Collections.Generic;
using System.Linq;

namespace lab1_2
{
    public class NumericalMethodImplementation
    {
        private double _aBound;
        private double _bBound;
        private double _epsilon;

        public List<double> ApproximateRoots;
        public List<double> ApproximatedRoots;

        public double ABound { get => this._aBound;
            set {
                if (_bBound < value)
                {
                    _aBound = _bBound;
                    _bBound = value;
                }
                else _aBound = value;
            }
        }
        public double BBound { get => this._bBound;
            set {
                if (_aBound > value)
                {
                    _bBound = ABound;
                    _aBound = value;
                }
                else _bBound = value;
            } 
        }

        public double Epsilon
        {
            get => this._epsilon;
            set => this._epsilon = value;
        }

        public NumericalMethodImplementation()
        {
            ApproximateRoots = new List<double>();
            ApproximatedRoots = new List<double>();
        }
        public double Function(double x)
        {
            return Math.Pow(2d - x, x) - Math.Sin(Math.Sin(x));
        }

        public List<(double, double)> CalculateSeries() {
            ApproximateRoots.Clear();
            ApproximatedRoots.Clear();
            var iterationCount = (int) ((BBound - ABound) / Epsilon) + 1;
            var result = new List<(double, double)>();

            var previousFunctionValue = Function(ABound);

            for (var i = 0; i < iterationCount; i++) {
                var x = ABound + (i+1) * Epsilon;
                var y = Function(x);
                if (double.IsNaN(y))
                {
                    break;
                }

                if (i == 0)
                {
                    if (Function(ABound) * y < 0)
                    {
                        ApproximateRoots.Add((x - 0.3) - ((x+0.3) - (x-0.3)) * (Function(x-0.3) / (Function(x+0.3) - Function(x-0.3))));
                    }
                    
                    previousFunctionValue = y;
                    result.Add((x, y));

                    continue;
                }

                if (y * previousFunctionValue < 0)
                {
                    ApproximateRoots.Add((x - 0.3) - ((x+0.3) - (x-0.3)) * (Function(x-0.3) / (Function(x+0.3) - Function(x-0.3))));
                }
                
                previousFunctionValue = y;
                result.Add((x, y));
            }

            return result;
        }
        public void ChordMethod(double a, double b)
        {
            double xNext = 0;
            double temp;

            do
            {
                temp = xNext;
                xNext = b - Function(b) * (a - b) / (Function(a) - Function(b));
                a = b;
                b = temp;
            } while (Math.Abs(xNext - b) > Epsilon);

            ApproximatedRoots.Add(xNext);
        }

    }
}
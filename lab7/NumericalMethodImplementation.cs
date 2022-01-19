using System;
using System.Collections.Generic;

namespace lab7
{
    public class NumericalMethodImplementation
    {
        private double _aBound;
        private double _bBound;
        private double _hForGraph = 0.001;
        public double H { get; set; }

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

        public double F(double x)
        {
            return Math.Pow(Math.E, x) + 1;
        }
        
        public double FInt()
        {
            return Math.Pow(Math.E, BBound) + BBound - (Math.Pow(Math.E, ABound) + ABound);
        }

        public double RectanglesMethod(double a, double b, double h)
        {
            var n = CalculateN(a, b, ref h);
            var sum = 0d;
            for (var i = 0; i < n; i++)
            {
                sum += F(a + i * h);
            }

            return sum*h;
        }
        
        public double TrapezeMethod(double a, double b, double h)
        {
            var n = CalculateN(a, b, ref h);
            var sum = (F(a) + F(b)) / 2d;
            for (int i = 1; i < n; i++)
            {
                sum += F(a + i * h);
            }
            return sum*h;
        }
        
        public double SimpsonMethod(double a, double b, double h)
        {
            var n = CalculateN(a, b, ref h);
            if (n % 2 != 0)
            {
                n++;
                h = (b - a) / (double) n;
            }

            var firstSum = F(a) + F(b);
            var secondSum = 0d;
            var thirdSum = 0d;

            for (var i = 1; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    secondSum += F(a + i * h);
                }
                else
                {
                    thirdSum += F(a + i * h);
                }
            }

            var result = h * (1 / 3d) * (firstSum + 2 * secondSum + 4 * thirdSum);
            return result;
        }

        public List<(double, double)> CalculateSeries()
        {
            var result = new List<(double, double)>();
            for (int i = 0; i < (BBound - ABound)/_hForGraph; i++)
            {
                result.Add((ABound + i*_hForGraph, F(ABound + i*_hForGraph)));
            }

            return result;
        }
        
        private int CalculateN(double a, double b, ref double h)
        {
            var n = Math.Ceiling((b - a) / h);
            h = (b - a) / n;
            return (int) n;
        }

        public double CalculateTheRemainderTermOfTheQuadratureFormula(double a, double b, double h)
        {
            const double maxOfSecondDerivative = 2.718281828459045;
            return -1 * (b - a) * h * h * maxOfSecondDerivative / 12;
        }
    }
}
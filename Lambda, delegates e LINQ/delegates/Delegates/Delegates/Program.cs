using Delegates.Services;
using System;

namespace Delegates
{
    public delegate void BinaryNumericOperation(double n1, double n2);
    public class Program
    {
        public static void Main(string[] args)
        {
            double a = 10;
            double b = 12;
            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;

            op.Invoke(a,b);
        }
    }
}
using System;

namespace Bisection_Method_Solver
{
    class functions
    {
        public static double fun1(double x) => 5 * Math.Pow(x, 2) - 20;
        public static double fun2(double x) => 5 * Math.Pow(x, 3) - 2 * Math.Pow(x, 2) + 3 * x - 2;
        public static double fun3(double x) => 2 * Math.Sqrt(x);
        public static double fun4(double x) => 5*x * x + 8 * x - 15;
        public static double fun5(double x) => Math.Log(x + 4) - 8 * x + 15;
        public static double fun6(double x) => 5 * Math.Sqrt(x + 4) - 50;
        public static double fun7(double x) => ( ( 5 * Math.Sin(x + 4) - 50 ) / (Math.Sqrt(x*x +5) ) ) + 5*x;

        // public static double fun8(double x) => ( // Add your function here );

    }
}

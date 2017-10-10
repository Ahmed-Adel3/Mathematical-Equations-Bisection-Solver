using System;

namespace Bisection_Method_Solver
{
    class Program
    {
        static void Main(string[] args)
        {
            double start = 0;     // Add the start of the Interval
            double end = 200;     // Add the end of the Interval
            double? guess = null;  // Add your guess of the solution here ( optional )


            Func<double, double> FunctionDelegate = functions.fun7;   // point to your function here

            double? answer = Bisection.Bisection_method(FunctionDelegate, start, end, guess);

            if (answer != null)
            {
                Console.WriteLine($"The Root = {answer}");
            }
        }
    }
}

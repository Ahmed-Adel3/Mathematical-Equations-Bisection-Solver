using System;

namespace Bisection_Method_Solver
{
    // Delegate declaration
    public delegate TResult Func<in T, out TResult>(T arg);

    class Bisection
    { 
        static double FunctionStart;  // F(x) of the start point
        static double FunctionEnd;    // F(x) of the end point
        static double FunctionAvg;    // F(x) of the average point
        static double Avg;
        static double Sign;
        static double Tolerance;
        
        /// <summary>
        /// Bisection Method solver method
        /// </summary>
        /// <param name="FunctionDel"> Pointer to function </param>
        /// <param name="Start"> Start of the Interval </param>
        /// <param name="End"> End of the Interval</param>
        /// <param name="Guess"> User guess of the solution ( optional ) </param>
        /// <returns></returns>
        public static double? Bisection_method ( Func<double,double> FunctionDel , double Start , double End , double? Guess)
        {
            Avg = (Guess.HasValue) ? Guess.Value : ( (Start + End) / 2);
            
            do
            {
                FunctionStart = FunctionDel(Start);
                FunctionEnd = FunctionDel(End);
                FunctionAvg = FunctionDel(Avg);
                Sign = FunctionStart * FunctionAvg;

                //check the Interval
                try
                {
                    if (FunctionStart * FunctionEnd > 0 || double.IsNaN(FunctionStart) || double.IsNaN(FunctionEnd) )
                    {
                        throw new WrongIntervalException();
                    }
                }
                catch(WrongIntervalException Ex)
                {
                    Console.WriteLine(Ex.Message);
                    return null;
                }

                // Check if one of the initial values is the root
                if (FunctionStart == 0)
                {
                    return Start;
                }
                else if (FunctionAvg == 0)
                {
                    return Avg;
                }
                else if (FunctionEnd == 0)
                {
                    return End;
                }
                
                // Narrowing Interval
                if (Sign < 0)
                {
                    End = Avg;
                }
                else if (Sign > 0)
                {
                    Start = Avg;
                }
                   
                Avg = (Start + End) / 2;

                Tolerance = Math.Abs(FunctionEnd - FunctionStart);
            }
            while ( Tolerance > 0.0001 );

            return End;
        }
    }
}

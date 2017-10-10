using System;

namespace Bisection_Method_Solver
{
    class WrongIntervalException:Exception
    {
        /// <summary>
        /// This Exception will be thrown in the following cases:
        /// 1- If the Interval Entered does not contain the root.
        /// 2- If the Interval Entered contains more than one root.
        /// 3- If one of the values inside the inteval causes a math error
        ///      ex. • Divide by zero. 
        ///          • Square root of Negative value.
        ///          • Log() or Ln() of negative numbers or zero.
        /// </summary>
        public WrongIntervalException()
        :base("This Interval contains no roots,more than one root or a value causing Math Error")
        {
        }
    }
}

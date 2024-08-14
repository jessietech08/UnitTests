using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode
{
    /*****************************************************************************
    * 
    * YOU MAY REFACTOR THE PARAMETER NAMES BUT DO NOT CHANGE THE METHOD SIGNATURES
    * 
    * ***************************************************************************/
    public static class SimpleMath
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            // checks if a or be is not a number
            if (double.IsNaN(a) || double.IsNaN(b))
            {
                throw new ArgumentException("Inputs must be valid numbers");
            }

            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            // checks if a or be is not a number
            if (double.IsNaN(a) || double.IsNaN(b))
            {
                throw new ArgumentException("Inputs must be valid numbers");
            }

            if (b == 0)
            {
                throw new ArgumentException("Denominator cannot be zero");
            }
            return a / b;
        }
    }
}

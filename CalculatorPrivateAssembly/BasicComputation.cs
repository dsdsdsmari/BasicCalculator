using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalculatorPrivateAssembly
{
    public class BasicComputation
    {
        public static float Add(float a, float b)
        {
            return a + b;
        }
        public static float Subtract(float a, float b)
        {
            return a - b;
        }
        public static float Multiply(float a, float b)
        {
            return a * b;
        }
        public static float Divide(float a, float b)
        {
            if (b == 0)
            {
                if (a == 0)
                {
                    Console.WriteLine("Error: Both dividend and divisor are zero. Division result is undefined.");
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed when divisor (input2) is zero.");
                }

                return float.NaN;
            }
            else
            {
                return a / b;
            }
        }

    }
}

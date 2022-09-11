using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphPlotter
{
    public enum MathFunction
    {
        Sine, Cosine,
        Square, Cube,
        Line,
    }

    public static class MathFunctionMethods
    {
        public static Func<double, double> GetFunc(this MathFunction mathFunction)
        {
            Func<double, double> func = null;
            switch(mathFunction)
            {
                case MathFunction.Sine:
                    func = Math.Sin;
                    break;
                case MathFunction.Cosine:
                    func = Math.Cos;
                    break;
                case MathFunction.Square:
                    func = x => x * x;
                    break;
                case MathFunction.Cube:
                    func = x => x * x * x;
                    break;
                case MathFunction.Line:
                    func = x => x;
                    break;
            }
            return func;
        }

        public static string GetFunctionName(this MathFunction mathFunction)
        {
            string functionName = null;
            switch (mathFunction)
            {
                case MathFunction.Sine:
                    functionName = "y = sin(x)";
                    break;
                case MathFunction.Cosine:
                    functionName = "y = cos(x)";
                    break;
                case MathFunction.Square:
                    functionName = "y = x^2";
                    break;
                case MathFunction.Cube:
                    functionName = "y = x^3";
                    break;
                case MathFunction.Line:
                    functionName = "y = x";
                    break;
            }
            return functionName;
        }
    }
}

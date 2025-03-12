using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace GraphicBackend
{
    public class FunctionF : Function
    {
        double a, b, c, d;
        //The positions in the array "parameters" correspond to the following letters:
        // 0 = a, 1 = b, 2 = c, 3 = d

        public FunctionF(double[] parameters)
        {
            a = parameters[0];
            b = parameters[1];
            c = parameters[2];
            d = parameters[3];

        }

        protected override void FindDomain()
        {
            Domain.Add((-b / a, double.PositiveInfinity));
            double critPoint = -d / c;
            if (critPoint > -b / a)
                Domain.Add((critPoint,critPoint));
        }
        public override double EvaluateX(double x)
        {
            if (IsInDomain(x))
                return Math.Log(a * x + b) / c * x + d;
            return double.NaN;
        }
        protected override double EvaluateFirstDerivative(double x)
        {
            if (IsInFirstDerivativeDomain(x))
                return (a / ((a * x + b) * (c * x + d))) - (c * Math.Log(a * x + b) / ((c * x + d) * (c * x + d)));
            return double.NaN;
        }
        protected override double EvaluateSecondDerivative(double x)
        {
            if (IsInSecondDerivativeDomain(x))
                return (2 * c * c * Math.Log(a * x + b) / ((c * x + d) * (c * x + d) * (c * x + d))) - (a * a / ((a * x + b) * (a * x + b) * (c * x + d))) - (2 * a * c / ((a * x + b) * (c * x + d) * (c * x + d)));
            return double.NaN;
        }
    }
}

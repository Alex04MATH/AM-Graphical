using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicBackend
{
    public class Asymptotes
    {
        public AsymptoteType asymptoteType;
        // y = m
        double m; //Slope
        double b; //y-intercept
        double x; //Used if vertical asymptote

        public Asymptotes(double m, double b, double x = double.PositiveInfinity)
        {
            if (x != double.PositiveInfinity)
                this.x = x;
            this.m = m;
            this.b = b;
        }
        public string Equation()
        {
            if(asymptoteType == AsymptoteType.Vertical)
                return $"x = {x}";
            if(asymptoteType == AsymptoteType.Horizontal)
                return $"y = {b}";
            if(b == 0)
                return $"y = {m}x";
            if(b < 0)
                return $"y = {m}x - {Math.Abs(b)}";
            return $"y = {m}x + {b}";
        }
        public double EvaluateX(double x)
        {
            return m * x + b ;
        }
    }
    public enum AsymptoteType
    {
        Vertical,
        Horizontal,
        ObliqueToInfinity,
        ObliqueToMinusInfinity
    }
}

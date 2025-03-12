﻿namespace GraphicBackend
{
    public interface IFunction
    {
        public double EvaluateX(double x);
        public string FirstDerivative();
        public string SecondDerivative();
        //Intervals
        public List<(double,double)> Domain { get; set; }
        public List<(double,double)> ContinuityIntervals { get; set; }
        public List<(double,double)> IncreasingIntervals {  get; set; }
        public List<(double,double)> DecreasingIntervals { get; set; }
        public List<(double, double)> ConcaveIntervals { get; set; }
        public List<(double, double)> ConvexIntervals { get; set; }
        //Points
        public List<(double, double)> LocalExtremes { get; set; }
        public List<(double, double)> TurningPoints { get; set; }
        //Asymptotes
        public List<Asymptotes> Asymptotes { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicBackend
{
    public abstract class Function : IFunction
    {
        protected List<(double, double)> domain;
        protected List<(double, double)> continuityIntervals;
        protected List<(double, double)> increasingIntervals;
        protected List<(double, double)> decreasingIntervals;
        protected List<(double, double)> concaveIntervals;
        protected List<(double, double)> convexIntervals;
        protected List<(double, double)> localExtremes;
        protected List<(double, double)> turningPoints;
        protected List<Asymptotes> asymptotes;

        #region Interface
        public abstract double EvaluateX(double x);
        public abstract string FirstDerivative();
        public abstract string SecondDerivative();
        //Intervals
        public abstract List<(double, double)> Domain { get; set; }
        public abstract List<(double, double)> ContinuityIntervals { get; set; }
        public abstract List<(double, double)> IncreasingIntervals { get; set; }
        public abstract List<(double, double)> DecreasingIntervals { get; set; }
        public abstract List<(double, double)> ConcaveIntervals { get; set; }
        public abstract List<(double, double)> ConvexIntervals { get; set; }
        //Points
        public abstract List<(double, double)> LocalExtremes { get; set; }
        public abstract List<(double, double)> TurningPoints { get; set; }
        //Asymptotes
        public abstract List<Asymptotes> Asymptotes { get; set; }
        #endregion

        protected abstract double EvaluateFirstDerivative(double x);
        protected abstract double EvaluateSecondDerivative(double x);
        protected abstract void FindDomain();
        protected abstract void FindFirstDerivativeDomain();
        protected abstract void FindSecondDerivativeDomain();
        protected abstract void FindContinuity();
        protected abstract void FindIncreasingIntervals();
        protected abstract void FindDecreasingIntervals();
        protected abstract void FindConcaveIntervals();
        protected abstract void FindConvexIntervals();
        protected abstract void FindLocalExtremes();
        protected abstract void FindTurningPoints();
        protected abstract void FindObliquesAsymptotes();
        protected abstract bool IsInDomain(double x);
        protected abstract bool IsInFirstDerivativeDomain(double x);
        protected abstract bool IsInSecondDerivativeDomain(double x);
    }
}

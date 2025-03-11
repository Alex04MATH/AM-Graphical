using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicBackend
{
    public abstract class Function : IFunction
    {
        private List<(double, double)> domain;
        private List<(double, double)> continuityIntervals;
        private List<(double, double)> increasingIntervals;
        private List<(double, double)> decreasingIntervals;
        private List<(double, double)> concaveIntervals;
        private List<(double, double)> convexIntervals;
        private List<(double, double)> localExtremes;
        private List<(double, double)> turningPoints;
        private List<Asymptotes> asymptotes;

        #region Interface
        public abstract int EvaluateX(double x);
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
        protected abstract void FindContinuity();
        protected abstract void FindIncreasingIntervals();
        protected abstract void FindDecreasingIntervals();
        protected abstract void FindConcaveIntervals();
        protected abstract void FindConvexIntervals();
        protected abstract void FindLocalExtremes();
        protected abstract void FindTurningPoints();
        protected abstract void FindObliquesAsymptotes();
    }
}

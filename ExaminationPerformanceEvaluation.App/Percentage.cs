using System;

namespace ExaminationPerformanceEvaluation.App
{
    public class Percentage : IEvaluationStrategy
    {
        private double _marksScored;
        private double _totalMarks;

        public Percentage(double marksScored, double totalMarks)
        {
            this._marksScored = marksScored;
            this._totalMarks = totalMarks;
        }

        string IEvaluationStrategy.EvaluatePerformance()
        {
            double percentage = (_marksScored / _totalMarks) * 100;
            percentage = Math.Round(percentage, 2);
            return percentage.ToString();
        }
    }

}

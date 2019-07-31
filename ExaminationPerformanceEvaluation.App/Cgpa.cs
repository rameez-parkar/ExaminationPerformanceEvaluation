using System;

namespace ExaminationPerformanceEvaluation.App
{
    public class Cgpa : IEvaluationStrategy
    {
        private double _totalGradePoints;
        private double _totalCredits;

        public Cgpa(double totalGradePoints, double totalCredits)
        {
            this._totalGradePoints = totalGradePoints;
            this._totalCredits = totalCredits;
        }

        string IEvaluationStrategy.EvaluatePerformance()
        {
            double cgpa = _totalGradePoints / _totalCredits;
            cgpa = Math.Round(cgpa, 2);
            return cgpa.ToString();
        }
    }

}

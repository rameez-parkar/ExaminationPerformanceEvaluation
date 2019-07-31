namespace ExaminationPerformanceEvaluation.App
{
    public class Grade : IEvaluationStrategy
    {
        private double _marksScored;
        private double _totalMarks;

        public Grade(double marksScored, double totalMarks)
        {
            this._marksScored = marksScored;
            this._totalMarks = totalMarks;
        }

        string IEvaluationStrategy.EvaluatePerformance()
        {
            double percentage = (_marksScored / _totalMarks) * 100;
            string grade;

            if (percentage >= 80)
            {
                grade = "A";
            }
            else if(percentage >= 70 && percentage < 80)
            {
                grade = "B";
            }
            else if(percentage >= 60 && percentage < 70)
            {
                grade = "C";
            }
            else if(percentage >= 50 && percentage < 60)
            {
                grade = "D";
            }
            else if (percentage >= 40 && percentage < 50)
            {
                grade = "E";
            }
            else
            {
                grade = "F";
            }

            return grade;
        }
    }

}

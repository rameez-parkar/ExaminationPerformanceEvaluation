namespace ExaminationPerformanceEvaluation.App
{
    public class PerformanceEvaluator
    {
        private IEvaluationStrategy _evaluationStrategy;

        public PerformanceEvaluator(IEvaluationStrategy evaluationStrategy)
        {
            this._evaluationStrategy = evaluationStrategy;
        }

        public string EvaluatePerformance()
        {
            return _evaluationStrategy.EvaluatePerformance();
        }
    }
}

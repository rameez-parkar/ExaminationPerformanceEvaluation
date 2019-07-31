using ExaminationPerformanceEvaluation.App;
using System;
using Xunit;

namespace ExaminationPerformanceEvaluation.Test
{
    public class PerformanceEvaluationTest
    {
        private PerformanceEvaluator _performanceEvaluator;
        [Fact]
        public void PercentageStrategyTest()
        {
            double marksObtained = 510;
            double totalMarks = 650;

            _performanceEvaluator = new PerformanceEvaluator(new Percentage(marksObtained, totalMarks));

            var expected = "78.46";
            var actual = _performanceEvaluator.EvaluatePerformance();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CgpaStrategyTest()
        {
            double totalGradePoints = 184;
            double totalCredits = 22;

            _performanceEvaluator = new PerformanceEvaluator(new Cgpa(totalGradePoints, totalCredits));

            var expected = "8.36";
            var actual = _performanceEvaluator.EvaluatePerformance();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GradeStrategyTest()
        {
            double marksObtained = 510;
            double totalMarks = 650;

            _performanceEvaluator = new PerformanceEvaluator(new Grade(marksObtained, totalMarks));

            var expected = "B";
            var actual = _performanceEvaluator.EvaluatePerformance();

            Assert.Equal(expected, actual);
        }
    }
}

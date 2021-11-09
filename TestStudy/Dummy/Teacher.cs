using System.Collections.Generic;

namespace TestStudy.Dummy
{
    public class Teacher
    {
        public Grades generateGrade(List<Mark> marksList) {

            var aggregate = decimal.Zero;

            foreach (var mark in marksList)
            {
                aggregate += mark.GetMark();
            }

            var percentage = calculatePercent(aggregate, marksList.Count);

            if (percentage > 90.00m) {
                return Grades.Excellent;
            }

            if (percentage > 75.00m) {
                return Grades.VeryGood;
            }

            if (percentage > 60.00m) {
                return Grades.Good;
            }

            if (percentage > 40.00m) {
                return Grades.Average;
            }

            return Grades.Poor;
        }

        private decimal calculatePercent(decimal aggregate, int numberOfSubjects) {
            decimal percent = aggregate/ numberOfSubjects;
            return percent;
        }
    }
}
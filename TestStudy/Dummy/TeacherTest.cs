using System.Collections.Generic;
using Xunit;

namespace TestStudy.Dummy
{
    public class TeacherTest
    {
        [Fact]
        public void when_marks_above_seventy_five_percent_returns_very_good()
        {
            // Arrange
            var dummyStudent = new  DummyStudent();
            var inEnglish = new Mark(dummyStudent, 81.00m);
            var inMath = new Mark(dummyStudent, 97.00m);
            var inHistory = new Mark(dummyStudent, 79.00m);
            // Act
            var marks = new List<Mark>()
            {
                inEnglish, inMath, inHistory
            };
            var grade = new Teacher().generateGrade(marks);
            // Assert
            Assert.Equal(Grades.VeryGood, grade);
        }
    }
}
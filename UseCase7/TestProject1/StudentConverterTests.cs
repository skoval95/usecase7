using UseCase7.Converters;
using UseCase7.Models;

namespace TestProject1
{
    public class StudentConverterTests
    {
        private readonly StudentConverter _converter;

        public StudentConverterTests()
        {
            _converter = new StudentConverter();
        }

        [Fact]
        public void GivenStudentWithAgeAbove21AndGradeAbove90_HonorRollIsTrue()
        {
            var students = new List<Student> { new Student { Age = 22, Grade = 95 } };
            var result = _converter.ConvertStudents(students);
            Assert.True(result[0].HonorRoll);
        }

        [Fact]
        public void GivenStudentWithAgeLessThan21AndGradeAbove90_ExceptionalIsTrue()
        {
            var students = new List<Student> { new Student { Age = 20, Grade = 95 } };
            var result = _converter.ConvertStudents(students);
            Assert.True(result[0].Exceptional);
        }

        [Fact]
        public void GivenStudentWithGradeBetween71And90_PassedIsTrue()
        {
            var students = new List<Student> { new Student { Age = 20, Grade = 80 } };
            var result = _converter.ConvertStudents(students);
            Assert.True(result[0].Passed);
        }

        [Fact]
        public void GivenStudentWithGrade70OrLess_PassedIsFalse()
        {
            var students = new List<Student> { new Student { Age = 20, Grade = 70 } };
            var result = _converter.ConvertStudents(students);
            Assert.False(result[0].Passed);
        }

        [Fact]
        public void GivenEmptyList_ReturnsEmptyList()
        {
            var students = new List<Student>();
            var result = _converter.ConvertStudents(students);
            Assert.Empty(result);
        }

        [Fact]
        public void GivenNullInput_ThrowsException()
        {
            Assert.Throws<ArgumentNullException>(() => _converter.ConvertStudents(null));
        }
    }
}
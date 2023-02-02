using Exercise.Apis.Models;

namespace UnitTest.DataForTest
{
    public static class OrderData
    {
        public static IEnumerable<object[]> TemplateOne()
        {
            yield return new object[]
            {
                new TeacherModel()
                {
                    FullName = "teacher-2",
                    Students = new List<StudentModel>
                    {
                        new()
                        {
                            FullName = "student-5",
                            DateOfBirth = DateTime.Now.AddYears(-5)
                        },
                        new()
                        {
                            FullName = "student-2",
                            DateOfBirth = DateTime.Now
                        },
                        new()
                        {
                            FullName = "student-3",
                            DateOfBirth = DateTime.Now.AddYears(-1)
                        },
                        new()
                        {
                            FullName = "student-4",
                            DateOfBirth = DateTime.Now.AddYears(-2)
                        }
                    }
                },
                new TeacherModel()
                {
                    FullName = "teacher-1",
                    Students = new List<StudentModel>
                    {
                        new()
                        {
                            FullName = "student-7",
                            DateOfBirth = DateTime.Now.AddYears(-1)
                        },
                        new()
                        {
                            FullName = "student-8",
                            DateOfBirth = DateTime.Now.AddYears(2)
                        },
                        new()
                        {
                            FullName = "student-9",
                            DateOfBirth = DateTime.Now.AddYears(4)
                        },
                        new()
                        {
                            FullName = "student-10",
                            DateOfBirth = DateTime.Now.AddYears(-2)
                        }
                    }
                }
            };
        }
    }
}
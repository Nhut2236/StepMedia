using Exercise.Apis.Models;
using Exercise.Apis.Services.Teachers;

namespace UnitTest.DataForTest
{
    public static class TeacherOrderData
    {
        public static readonly TeacherOrderServiceRequest StudentsIsValidDataTemplate =
            new TeacherOrderServiceRequest(new List<TeacherOrderServiceFields>()
            {
                new TeacherOrderServiceFields()
                {
                    FullName = "B",
                    Students = new List<StudentModel>()
                    {
                        new StudentModel()
                        {
                            FullName = "student-1",
                            DateOfBirth = DateTime.Now
                        },
                        new StudentModel()
                        {
                            FullName = "student-2",
                            DateOfBirth = DateTime.Now.AddYears(-3)
                        },
                        new StudentModel()
                        {
                            FullName = "student-3",
                            DateOfBirth = DateTime.Now.AddYears(-1)
                        },
                        new StudentModel()
                        {
                            FullName = "student-1",
                            DateOfBirth = DateTime.Now
                        },
                        new StudentModel()
                        {
                            FullName = "student-2",
                            DateOfBirth = DateTime.Now.AddYears(-3)
                        },
                        new StudentModel()
                        {
                            FullName = "student-3",
                            DateOfBirth = DateTime.Now.AddYears(-1)
                        },
                        new StudentModel()
                        {
                            FullName = "student-1",
                            DateOfBirth = DateTime.Now
                        },
                        new StudentModel()
                        {
                            FullName = "student-2",
                            DateOfBirth = DateTime.Now.AddYears(-3)
                        },
                        new StudentModel()
                        {
                            FullName = "student-3",
                            DateOfBirth = DateTime.Now.AddYears(-1)
                        },
                        new StudentModel()
                        {
                            FullName = "student-1",
                            DateOfBirth = DateTime.Now
                        },
                        new StudentModel()
                        {
                            FullName = "student-2",
                            DateOfBirth = DateTime.Now.AddYears(-3)
                        },
                        new StudentModel()
                        {
                            FullName = "student-3",
                            DateOfBirth = DateTime.Now.AddYears(-1)
                        },
                        new StudentModel()
                        {
                            FullName = "student-1",
                            DateOfBirth = DateTime.Now
                        },
                        new StudentModel()
                        {
                            FullName = "student-2",
                            DateOfBirth = DateTime.Now.AddYears(-3)
                        },
                        new StudentModel()
                        {
                            FullName = "student-3",
                            DateOfBirth = DateTime.Now.AddYears(-1)
                        },
                    }
                },
                new TeacherOrderServiceFields()
                {
                    FullName = "A",
                    Students = new List<StudentModel>()
                    {
                        new StudentModel()
                        {
                            FullName = "student-1",
                            DateOfBirth = DateTime.Now.AddYears(-7)
                        },
                        new StudentModel()
                        {
                            FullName = "student-2",
                            DateOfBirth = DateTime.Now.AddYears(-3)
                        },
                        new StudentModel()
                        {
                            FullName = "student-3",
                            DateOfBirth = DateTime.Now.AddYears(-1)
                        },
                        new StudentModel()
                        {
                            FullName = "student-1",
                            DateOfBirth = DateTime.Now
                        },
                        new StudentModel()
                        {
                            FullName = "student-2",
                            DateOfBirth = DateTime.Now.AddYears(-3)
                        },
                        new StudentModel()
                        {
                            FullName = "student-3",
                            DateOfBirth = DateTime.Now.AddYears(-10)
                        },
                        new StudentModel()
                        {
                            FullName = "student-1",
                            DateOfBirth = DateTime.Now
                        },
                        new StudentModel()
                        {
                            FullName = "student-2",
                            DateOfBirth = DateTime.Now.AddYears(-3)
                        },
                        new StudentModel()
                        {
                            FullName = "student-3",
                            DateOfBirth = DateTime.Now.AddYears(-1)
                        },
                        new StudentModel()
                        {
                            FullName = "student-1",
                            DateOfBirth = DateTime.Now
                        },
                        new StudentModel()
                        {
                            FullName = "student-2",
                            DateOfBirth = DateTime.Now.AddYears(-14)
                        },
                        new StudentModel()
                        {
                            FullName = "student-3",
                            DateOfBirth = DateTime.Now.AddYears(-12)
                        },
                        new StudentModel()
                        {
                            FullName = "student-1",
                            DateOfBirth = DateTime.Now
                        },
                        new StudentModel()
                        {
                            FullName = "student-2",
                            DateOfBirth = DateTime.Now.AddYears(-3)
                        },
                        new StudentModel()
                        {
                            FullName = "student-3",
                            DateOfBirth = DateTime.Now.AddYears(-10)
                        },
                    }
                }
            });


        public static readonly TeacherOrderServiceRequest StudentsIsEmptyTemplate =
            new TeacherOrderServiceRequest(new List<TeacherOrderServiceFields>()
            {
                new TeacherOrderServiceFields()
                {
                    FullName = "B",
                },
                new TeacherOrderServiceFields()
                {
                    FullName = "A"
                }
            });
    }
}
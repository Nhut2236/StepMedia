namespace Exercise.Apis.Services.Teachers
{
    public interface ITeacherService
    {
        Task<TeacherOrderServiceResponse> OrderTeachersAndStudents(TeacherOrderServiceRequest teacherOrderServiceRequest);
    }
}


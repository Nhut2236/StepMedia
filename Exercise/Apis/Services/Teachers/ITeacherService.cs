namespace Exercise.Apis.Services.Teachers
{
    public interface ITeacherService
    {
        TeacherOrderServiceResponse Order(TeacherOrderServiceRequest teacherOrderServiceRequest);
    }
}


using Exercise.Base.Request;

namespace Exercise.Apis.Services.Teachers
{
    public class TeacherOrderServiceRequest : BaseRequest<List<TeacherOrderServiceFields>>
    {
        public TeacherOrderServiceRequest(List<TeacherOrderServiceFields> teacherOrderServiceFieldsList) : base(
            teacherOrderServiceFieldsList)
        {
        }
    }
}
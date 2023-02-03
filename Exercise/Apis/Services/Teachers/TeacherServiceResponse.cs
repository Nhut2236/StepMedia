using Exercise.Apis.Models;
using Exercise.Base.Response;

namespace Exercise.Apis.Services.Teachers
{
    public class TeacherOrderServiceResponse : BaseResponse<List<TeacherModel>, List<TeacherOrderServiceFields>>
    {
        public TeacherOrderServiceResponse(TeacherOrderServiceRequest teacherOrderServiceRequest) : base(teacherOrderServiceRequest)
        {
        }
    }
}
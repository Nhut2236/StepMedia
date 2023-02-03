using Exercise.Apis.Models;
using Exercise.Base.Response;

namespace Exercise.Apis.Services.Students
{
    public class StudentCreateServiceResponse : BaseResponse<StudentModel, StudentCreateFields>
    {
        public StudentCreateServiceResponse(StudentCreateServiceRequest studentCreateServiceRequest) : base(studentCreateServiceRequest) { }
    }
    
    public class StudentGetServiceResponse : BaseResponse<List<StudentGetResource>, StudentGetFields>
    {
        public StudentGetServiceResponse(StudentGetServiceRequest studentGetServiceRequest) : base(studentGetServiceRequest) { }
    }

    public class StudentDeleteServiceResponse : BaseResponse<List<StudentModel>, List<StudentDeleteFields>>
    {
        public StudentDeleteServiceResponse(StudentDeleteServiceRequest studentDeleteServiceRequest) : base(studentDeleteServiceRequest) { }
    }
}

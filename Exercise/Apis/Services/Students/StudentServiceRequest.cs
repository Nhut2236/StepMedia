using Exercise.Base.Request;

namespace Exercise.Apis.Services.Students
{
    public class StudentCreateServiceRequest : BaseRequest<StudentCreateFields>
    {
        public StudentCreateServiceRequest(StudentCreateFields studentModel) : base(studentModel) { }
    }
    
    public class StudentDeleteServiceRequest : BaseRequest<List<StudentDeleteFields>>
    {
        public StudentDeleteServiceRequest(List<StudentDeleteFields> studentModels) : base(studentModels) { }
    }
    
    public class StudentGetServiceRequest : BaseRequest<StudentGetFields>
    {
        public StudentGetServiceRequest(StudentGetFields studentQueries) : base(studentQueries) { }
    }

}

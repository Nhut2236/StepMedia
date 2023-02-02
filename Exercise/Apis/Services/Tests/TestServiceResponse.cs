using Exercise.Apis.Models;
using Exercise.Base.Response;

namespace Exercise.Apis.Services.Tests
{
    public class TestOrderServiceResponse : BaseResponse<List<TeacherModel>, List<TestOrderServiceFields>>
    {
        public TestOrderServiceResponse(TestOrderServiceRequest testOrderServiceRequest) : base(testOrderServiceRequest)
        {
        }
    }
}
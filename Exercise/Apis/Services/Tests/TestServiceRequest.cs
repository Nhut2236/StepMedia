using Exercise.Base.Request;

namespace Exercise.Apis.Services.Tests
{
    public class TestOrderServiceRequest : BaseRequest<List<TestOrderServiceFields>>
    {
        public TestOrderServiceRequest(List<TestOrderServiceFields> testOrderServiceFieldsList) : base(
            testOrderServiceFieldsList)
        {
        }
    }
}
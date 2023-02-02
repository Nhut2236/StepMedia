using Exercise.Apis.Services.Tests;
using Xunit;

namespace UnitTest
{
    public class ExerciseTest
    {
        private readonly ITestService _testService;
        
        public ExerciseTest(ITestService testService)
        {
            _testService = testService;
        }
        
        [Theory]
        [MemberData(nameof(DataForTest.OrderData.TemplateOne), MemberType = typeof(object))]
        public void TestOrder(List<TestOrderServiceFields> teachers)
        {
            TestOrderServiceResponse testOrderServiceResponse = _testService.OrderTeachersAndStudents(
                new TestOrderServiceRequest(teachers));
            
            Assert.False(testOrderServiceResponse.HasErrors());
        }
    } 
}


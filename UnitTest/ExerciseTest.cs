using Exercise.Apis.Services.Tests;
using Xunit;

namespace UnitTest
{
    public class ExerciseTest
    {
        private readonly ITestService _testService;

        public static IEnumerable<object[]> AdminDevicesFetchActionTestData()
        {
            
        }

        public ExerciseTest(ITestService testService)
        {
            _testService = testService;
        }
        
        [Theory]
        [ClassData(typeof(TestOrderServiceFields))]
        public void TestOrder(List<TestOrderServiceFields> teachers)
        {
            TestOrderServiceResponse testOrderServiceResponse = _testService.OrderTeachersAndStudents(
                new TestOrderServiceRequest(teachers));
            
            Assert.False(testOrderServiceResponse.HasErrors());
        }
    } 
}


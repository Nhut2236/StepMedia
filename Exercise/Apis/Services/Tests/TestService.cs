using AutoMapper;
using Exercise.Commons;

namespace Exercise.Apis.Services.Tests
{
    public class TestService : ITestService
    {
        private readonly Merger _merger;

        public TestService(IMapper mapper)
        {
            _merger = new Merger(mapper.ConfigurationProvider);
        }

        public TestOrderServiceResponse OrderTeachersAndStudents(TestOrderServiceRequest testOrderServiceRequest)
        {
            TestOrderServiceResponse testOrderServiceResponse = new TestOrderServiceResponse(testOrderServiceRequest);
            try
            {
                List<TestOrderServiceFields> teachers = testOrderServiceRequest.Fields;
                teachers = teachers
                    .OrderBy(_ =>
                    {
                        _.Students = _.Students.OrderBy(s => s.DateOfBirth).ToList();
                        return _.FullName;
                    })
                    .ThenBy(_ => _.FullName)
                    .ToList();

                _merger.MergeData(testOrderServiceResponse, teachers);
            }
            catch (Exception ex)
            {
                testOrderServiceResponse.AddException(ex);
            }

            return testOrderServiceResponse;
        }
    }
}
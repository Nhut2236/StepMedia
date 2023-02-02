using AutoMapper;
using Exercise.Apis.Controllers.Params;
using Exercise.Apis.Services.Tests;
using Exercise.Base.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Exercise.Apis.Controllers
{
    [ApiController]
    [Route("api/v{version:ApiVersion}/test")]
    [ApiVersion("1.0")]
    public class TestController : ApiController
    {
        private readonly IMapper _mapper;
        private readonly ITestService _testService;

        public TestController(IMapper mapper, ITestService testService)
        {
            _mapper = mapper;
            _testService = testService;
        }
        
        [HttpPost]
        public Task<ActionResult> Order([FromBody] List<TestOrderParams> testOrderParamsList)
        {
            List<TestOrderServiceFields> testOrderServiceFieldsList = _mapper.Map<List<TestOrderServiceFields>>(testOrderParamsList);
            TestOrderServiceRequest testOrderServiceRequest = new TestOrderServiceRequest(testOrderServiceFieldsList);
            TestOrderServiceResponse testOrderServiceResponse =
                _testService.OrderTeachersAndStudents(testOrderServiceRequest);
            
            return Task.FromResult(StepMediaCollection(testOrderServiceResponse));
        }
    }
}


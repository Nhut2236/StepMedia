using AutoMapper;
using Exercise.Apis.Controllers.Params;
using Exercise.Apis.Services.Teachers;
using Exercise.Base.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Exercise.Apis.Controllers
{
    [ApiController]
    [Route("api/v{version:ApiVersion}/teacher")]
    [ApiVersion("1.0")]
    public class TeacherController : ApiController
    {
        private readonly IMapper _mapper;
        private readonly ITeacherService _teacherService;

        public TeacherController(IMapper mapper, ITeacherService teacherService)
        {
            _mapper = mapper;
            _teacherService = teacherService;
        }
        
        [HttpPost]
        public async Task<ActionResult> Order([FromBody] List<TeacherOrderParams> teacherOrderParamsList)
        {
            List<TeacherOrderServiceFields> teacherOrderServiceFieldsList = _mapper.Map<List<TeacherOrderServiceFields>>(teacherOrderParamsList);
            TeacherOrderServiceRequest teacherOrderServiceRequest = new TeacherOrderServiceRequest(teacherOrderServiceFieldsList);
            TeacherOrderServiceResponse teacherOrderServiceResponse =
                await _teacherService.OrderTeachersAndStudents(teacherOrderServiceRequest);
            
            return StepMediaCollection(teacherOrderServiceResponse);
        }
    }
}


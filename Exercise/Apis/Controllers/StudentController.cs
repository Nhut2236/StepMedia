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
    public class StudentController : ApiController
    {
        private readonly IMapper _mapper;
        private readonly IStudentService _studentService;

        public StudentController(IMapper mapper, IStudentService studentService)
        {
            _mapper = mapper;
            _studentService = studentService;
        }
        
         #region Api Get Students
        
        [HttpGet]
        public async Task<ActionResult> Get([FromQuery] StudentGetParams studentGetParams)
        {
            StudentGetFields studentGetFields = _mapper.Map<StudentGetFields>(studentGetParams);
            StudentGetServiceRequest studentGetServiceRequest = new StudentGetServiceRequest(studentGetFields);
            StudentGetServiceResponse studentGetServiceResponse = await _studentService.Get(studentGetServiceRequest);
            
            return StepMediaCollection(studentGetServiceResponse);
        }
        
        #endregion Api Get Student

        #region Api Create Student
        
        [HttpPost]
        public async Task<ActionResult> Create(StudentCreateParams studentCreateParams)
        {
            StudentCreateFields studentCreateFields = _mapper.Map<StudentCreateFields>(studentCreateParams);
            StudentCreateServiceRequest studentCreateServiceRequest = new StudentCreateServiceRequest(studentCreateFields);
            StudentCreateServiceResponse studentCreateServiceResponse = await _StudentService.Create(studentCreateServiceRequest);

            return StepMediaItem(tudentCreateServiceResponse);
        }

        #endregion Api Create Student

        #region Api Delete Student
        
        [HttpDelete]
        public async Task<ActionResult> Delete([FromBody] StudentDeleteParams studentDeleteParams)
        {
            List<StudentDeleteFields> studentModels = studentDeleteParams.Ids.Select(id => new StudentDeleteFields{Id = id}).ToList();
            StudentDeleteServiceRequest studentDeleteServiceRequest = new StudentDeleteServiceRequest(studentModels);
            StudentDeleteServiceResponse studentDeleteServiceResponse = await _studentService.Delete(studentDeleteServiceRequest);
            
            return StepMediaCollection(studentDeleteServiceResponse);
        }
        
        #endregion Api Delete Student

        #region Api Search Student
        
        [HttpGet("search")]
        public async Task<ActionResult> Search([FromQuery] StudentSearchParams studentSearchParams)
        {
            StudentSearchFields studentSearchFields = _mapper.Map<StudentSearchFields>(studentSearchParams);
            StudentSearchServiceRequest studentSearchServiceRequest = new StudentSearchServiceRequest(studentSearchFields);
            StudentSearchServiceResponse studentSearchServiceResponse = await _studentService.Search(studentSearchServiceRequest);
            
            return StepMediaCollection(studentSearchServiceResponse);
        }
        
        #endregion Api Search Student
    }
}
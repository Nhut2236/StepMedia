using System.Text.Json;
using AutoMapper;
using Exercise.Apis.Models;
using Exercise.Commons;

namespace Exercise.Apis.Services.Students
{
    public class StudentService : IStudentService
    {
        private readonly Merger _merger;

        public StudentService(IMapper mapper)
        {
            _merger = new Merger(mapper.ConfigurationProvider);
        }

        #region Create
        public async Task<StudentCreateServiceResponse> Create(StudentCreateServiceRequest studentCreateServiceRequest)
        {
            StudentCreateServiceResponse studentCreateServiceResponse = new StudentCreateServiceResponse(studentCreateServiceRequest);
            try
            {
                // repair data
                StudentModel studentModel = studentCreateServiceRequest.Fields;

                // main execute 
                string fileName = "DataStore.json"; 
                string jsonString = JsonSerializer.Serialize(studentModel);
                await File.WriteAllTextAsync(fileName, jsonString);

                // merging data
                _merger.MergeData(studentCreateServiceResponse, studentModel);
            }
            catch (Exception e)
            {
                studentCreateServiceResponse.AddException(e);
            }
            return studentCreateServiceResponse;
        }
        #endregion Create
        
        #region Get
        public async Task<StudentGetServiceResponse> Get(StudentGetServiceRequest studentGetServiceRequest)
        {
            StudentGetServiceResponse studentGetServiceResponse = new StudentGetServiceResponse(studentGetServiceRequest);
            try
            {
                
            }
            catch (Exception e)
            {
                studentGetServiceResponse.AddException(e);
            }
            return studentGetServiceResponse;
        }
        #endregion Get
        
        #region Delete
        public async Task<StudentDeleteServiceResponse> Delete(StudentDeleteServiceRequest studentDeleteServiceRequest)
        {
            StudentDeleteServiceResponse studentDeleteServiceResponse = new StudentDeleteServiceResponse(studentDeleteServiceRequest);
            try
            {
                // repair data
                List<int> ids = studentDeleteServiceRequest.Fields.Select(item => item.Id).ToList();

             
                // response data
                _merger.MergeData(studentDeleteServiceResponse, studentDeleteServiceRequest.Fields);
            }
            catch (Exception e)
            {
                studentDeleteServiceResponse.AddException(e);
            }
            return studentDeleteServiceResponse;
        }
        #endregion Delete
    }
}


namespace Exercise.Apis.Services.Students
{
    public interface IStudentService
    {
        Task<StudentCreateServiceResponse> Create(StudentCreateServiceRequest studentCreateServiceRequest);
        Task<StudentGetServiceResponse> Get(StudentGetServiceRequest studentGetServiceRequest);
        Task<StudentDeleteServiceResponse> Delete(StudentDeleteServiceRequest studentDeleteServiceRequest);
    }
}

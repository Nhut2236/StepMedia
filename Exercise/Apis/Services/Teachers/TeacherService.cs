using AutoMapper;
using Exercise.Commons;

namespace Exercise.Apis.Services.Teachers
{
    public class TeacherService : ITeacherService
    {
        private readonly Merger _merger;

        public TeacherService(IMapper mapper)
        {
            _merger = new Merger(mapper.ConfigurationProvider);
        }

        public TeacherOrderServiceResponse Order(TeacherOrderServiceRequest teacherOrderServiceRequest)
        {
            TeacherOrderServiceResponse teacherOrderServiceResponse = new TeacherOrderServiceResponse(teacherOrderServiceRequest);
            try
            {
                List<TeacherOrderServiceFields> teachers = teacherOrderServiceRequest.Fields;
                teachers = teachers
                    .OrderBy(_ =>
                    {
                        _.Students = _.Students.OrderBy(s => s.DateOfBirth).ToList();
                        return _.FullName;
                    })
                    .ThenBy(_ => _.FullName)
                    .ToList();

                _merger.MergeData(teacherOrderServiceResponse, teachers);
            }
            catch (Exception ex)
            {
                teacherOrderServiceResponse.AddException(ex);
            }

            return teacherOrderServiceResponse;
        }
    }
}
using AutoMapper;
using Exercise.Apis.Models;
using Exercise.Commons;
using Exercise.Exceptions;

namespace Exercise.Apis.Services.Teachers
{
    public class TeacherService : ITeacherService
    {
        private readonly Merger _merger;

        public TeacherService(IMapper mapper)
        {
            _merger = new Merger(mapper.ConfigurationProvider);
        }

        public Task<TeacherOrderServiceResponse> OrderTeachersAndStudents(TeacherOrderServiceRequest teacherOrderServiceRequest)
        {
            TeacherOrderServiceResponse teacherOrderServiceResponse =
                new TeacherOrderServiceResponse(teacherOrderServiceRequest);
            try
            {
                // validate
                Validation(teacherOrderServiceResponse);

                if (teacherOrderServiceResponse.HasErrors())
                    return Task.FromResult(teacherOrderServiceResponse);

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

            return Task.FromResult(teacherOrderServiceResponse);
        }

        private void Validation(TeacherOrderServiceResponse teacherOrderServiceResponse)
        {
            var teachers = teacherOrderServiceResponse.Fields;

            var students = teachers.SelectMany(_ => _.Students).ToList();

            if (teachers.Count < 2)
                teacherOrderServiceResponse.AddException(new FailedValidationException("Teachers",
                    "Invalid array length !!!"));

            if (students.Count < 30)
                teacherOrderServiceResponse.AddException(new FailedValidationException(nameof(TeacherModel.Students),
                    "Invalid array length !!!"));
        }
    }
}
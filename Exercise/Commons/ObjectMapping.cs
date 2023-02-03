using AutoMapper;
using Exercise.Apis.Controllers.Params;
using Exercise.Apis.Services.Teachers;

namespace Exercise.Commons
{
    public class ObjectMapping : Profile
    {
        public ObjectMapping()
        {
            TeacherMapping();
        }

        private void TeacherMapping()
        {
            CreateMap<TeacherOrderParams, TeacherOrderServiceFields>();
        }
    }
}
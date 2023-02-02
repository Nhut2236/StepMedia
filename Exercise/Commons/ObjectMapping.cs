using AutoMapper;
using Exercise.Apis.Controllers.Params;
using Exercise.Apis.Services.Tests;

namespace Exercise.Commons
{
    public class ObjectMapping : Profile
    {
        public ObjectMapping()
        {
            TestMapping();
        }

        private void TestMapping()
        {
            CreateMap<TestOrderParams, TestOrderServiceFields>();
        }
    }
}
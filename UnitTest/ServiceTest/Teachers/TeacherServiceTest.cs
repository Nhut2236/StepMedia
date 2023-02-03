using Exercise.Apis.Services.Teachers;
using Exercise.Commons;
using Moq;
using UnitTest.DataForTest;
using Xunit;

namespace UnitTest.ServiceTest.Teachers
{
    public class TeacherServiceTest
    {
        #region  Setup

        private readonly ITeacherService  _teacherService;
        private readonly Mock<Merger> _mergerMock;

        public TeacherServiceTest()
        {
            _mergerMock = new Mock<Merger>();
            _teacherService = new TeacherService(_mergerMock.Object);
        }

        #endregion

        [Fact]
        public void OrderTeachersAndStudents_OrderTeachersAndStudentsIsNull_ThrownException()
        {
            // Arrange
            TeacherOrderServiceRequest teacherOrderServiceRequest = null;

            // Act & Assert                    
            Assert.ThrowsAsync<Exception>(() => _teacherService.OrderTeachersAndStudents(teacherOrderServiceRequest));
        }

        [Fact]
        public async Task OrderTeachersAndStudents_StudentsIsValidData_ReturnDataResponse()
        {
            // Arrange
            var request = TeacherOrderData.StudentsIsValidDataTemplate;

            // Action
            var response = await _teacherService.OrderTeachersAndStudents(request);

            // Assert
            Assert.NotEmpty(response.Result);
        }

        [Fact]
        public async Task OrderTeachersAndStudents_StudentsIsEmpty_ReturnDataResponse()
        {
            // Arrange
            var request = TeacherOrderData.StudentsIsEmptyTemplate;

            // Action
            var response = await _teacherService.OrderTeachersAndStudents(request);

            // Assert
            Assert.Empty(response.Result);
        }
    }
}


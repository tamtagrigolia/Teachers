using Teachers.Service.interfaces;

namespace Test
{
    public class Teacher_Service_Should
    {

        private readonly IUnitOfWork _unitOfWork;
        public Teacher_Service_Should()
        {
            _unitOfWork = new UnitOfWork();
        }
        [Fact]
        public async void Return_All_Teachers()
        {
            var actual = await _unitOfWork.Teacher.GetAllTeachersAsync();
            var expeced = new List<Teacher>()
            {
                new Teacher()
                {
                    Id = 2,
                    FirstName = "Giorgi",
                    LastName = "Gaxaria",
                    Pin = "2525",
                    PhoneNumber= "43255543",
                    Email = "Gxra@mail.ru"

                } };
        }

        [Fact]
        public async void Return_Single_Teacher()
        {
            var actual = await _unitOfWork.Teacher.GetTeachersByIdAsync(12);
        }


    }
}

  

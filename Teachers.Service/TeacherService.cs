

using Teachers.Models;
using Teachers.Service.interfaces;

namespace Teachers.Service
{
    public class TeacherService : ITeachersService
    {
        public Task AddNewTeacherssAsync(Teacher teachers)
        {
            throw new NotImplementedException();
        }

        public Task DeleteTeacherAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Teacher>> GetAllTeachersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Teacher> GetTeachersByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTeacherAsync(Teacher teachers)
        {
            throw new NotImplementedException();
        }
    }
}

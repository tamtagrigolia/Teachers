using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teachers.Models;

namespace Teachers.Service.interfaces
{
    public interface ITeachersService
    {
        Task<List<Teacher>> GetAllTeachersAsync();
        Task AddNewTeacherssAsync(Teacher teachers);
        Task<Teacher> GetTeachersByIdAsync(int id);
        Task UpdateTeacherAsync(Teacher teachers);
        Task DeleteTeacherAsync(int id);
    }
}

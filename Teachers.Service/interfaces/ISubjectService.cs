using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teachers.Models;

namespace Teachers.Service.interfaces
{
    internal interface ISubjectService
    {
        Task<List<Subject>> GetAllSubjectsAsync();
        Task AddNewSubjectAsync(Subject subject);
        Task<Subject> GetSubjectByIdAsync(int id);
        Task UpdateSubjectAsync(Subject subject);
        Task DeleteSubjectAsync(int id);
     
    }
}

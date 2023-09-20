using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teachers.Service.interfaces;

namespace Teachers.Service
{
    public class UnitOfWork : IUnitOfWork
    {
        public ITeachersService Teacher { get; private set; }
        public ISubjectService Subject { get; private set; }
        public IGroupService Group { get; private set; }

        public ISubjectService subject => throw new NotImplementedException();

        public UnitOfWork()
        {
            Teacher = new TeacherService();
            Subject = new SubjectService();
            Group = new GroupService();
        }
    }
}
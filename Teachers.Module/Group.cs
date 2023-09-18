using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teachers.Models
{
    public class Group
    {
        public string Name { get; set; }
        public int SubjectedId { get; set; }
        public int TeacherId{ get; set; }
        public int StudentId{ get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyTask.Core.Entities.Bases;

namespace UdemyTask.Core.Entities
{
    public class Teacher : BaseAudiTableEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}

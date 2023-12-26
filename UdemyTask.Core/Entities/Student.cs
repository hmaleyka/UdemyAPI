using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyTask.Core.Entities.Bases;

namespace UdemyTask.Core.Entities
{
    public  class Student : BaseAudiTableEntity
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public ICollection<StudentCourse> Courses { get; set; }
    }
}

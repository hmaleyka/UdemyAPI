using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyTask.Core.Entities.Bases;

namespace UdemyTask.Core.Entities
{
    public class Course : BaseAudiTableEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int? TeacherId { get; set; }
        public Teacher? teacher { get; set; }
        public ICollection<StudentCourse> studentCourses { get; set; }
    }
}

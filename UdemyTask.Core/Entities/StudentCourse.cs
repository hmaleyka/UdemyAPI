using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyTask.Core.Entities.Bases;

namespace UdemyTask.Core.Entities
{
    public class StudentCourse : BaseAudiTableEntity
    {
        public int? StudentId { get; set; }
        public Student? student { get; set; }
        public int? CourseId { get; set; }
        public Course? course { get; set; }
    }
}

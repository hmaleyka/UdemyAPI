using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyTask.Business.DTOs.CourseDtos
{
    public class CourseCreateDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int TeacherId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestMvc1.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string C_name { get; set; }
        public string C_coeffient { get; set; }

        public ICollection<Course_Student> course_Students { get; set; }
    }
}

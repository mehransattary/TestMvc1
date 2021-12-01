using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TestMvc1.Models
{
    public class Course_Student
    {
        [Key]
        public int Course_StudentId { get; set; }
        public int Course_id { get; set; }
     
        public int Students_id { get; set; }

        [ForeignKey("Students_id")]
        public Student Student  { get; set; }
        [ForeignKey("Course_id")]
        public Course Course { get; set; }
    }
}

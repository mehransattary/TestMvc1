using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestMvc1.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        //public int Id
        //{
        //    get
        //    {
        //        return Id;
        //    }
        //    set
        //    {
        //       this. Id = value;
        //    }
        //}
        [Display(Name ="نام")]
        [Required(ErrorMessage ="please........")]
        [MaxLength(100)]
        [Column("Fname")]
        public string FirstName { get; set; }
        public string LastName { get; set; }


        
        public int ManagerId { get; set; }



      
        [ForeignKey("ManagerId")]
        public Manager manager { get; set; }
        public ICollection<Course_Student> course_Students { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestMvc1.Models
{
    public class Manager
    {
        public int Id { get; set; }
        public string M_FirstName { get; set; }
        public string M_LastName { get; set; }

        public List<Student> students { get; set; }
    }
}

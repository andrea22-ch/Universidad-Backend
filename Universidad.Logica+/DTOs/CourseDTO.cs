using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Logica_.DTOs
{
   public class CourseDTO
    {

        [Required]

        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
    }
}

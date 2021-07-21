using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Logica_.DTOs
{
   public class LoginDTO
    {
        [Required]
        public String UserName{ get; set; }
        [Required]
        public String Password{ get; set; }

    }
}

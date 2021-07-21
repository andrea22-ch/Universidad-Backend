using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Logica_.Data
{
    class UniversityContext:DbContext
    {
        public UniversityContext():base(@"Server= DESKTOP-HSTF081; Database= University;Integrated Security=true")
        {

        }
    }
}

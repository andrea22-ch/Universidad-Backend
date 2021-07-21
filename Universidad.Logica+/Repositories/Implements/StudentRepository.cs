using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.Logica_.Models;

namespace Universidad.Logica_.Repositories.Implements
{
   public class StudentRepository : GenericRepository<Student>
    {
        public StudentRepository(UniversityEntities context):base(context)
        {
                
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.Logica_.Models;
using Universidad.Logica_.Repositories.Implements;

namespace Universidad.Logica_.Services.Implements
{
    class StudentService:GenericService<Student>
    {
        public StudentService(IStudentRepository studentRepository):base(studentRepository)
        {

        }
    }
}

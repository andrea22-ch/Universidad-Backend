using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.Logica_.Models;

namespace Universidad.Logica_.Services
{
   public  interface ICourseService:IGenericService<Course>
    {
        Task<bool> DeleteCheckOnEntity(int id);
    }

    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.Logica_.Models;

namespace Universidad.Logica_.Repositories
{
    public interface ICourseRepository:IGenericRepository<Course>
    {
        Task<bool> DeleteCheckOnEntity(int id);
    }
}

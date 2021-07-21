using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.Logica_.Models;
using Universidad.Logica_.Services;

namespace Universidad.Logica_.Repositories.Implements
{
   public class CourseRepository : GenericRepository<Course>, ICourseRepository
    {
        private readonly UniversityEntities db;
        public CourseRepository(UniversityEntities context):base(context)
        {
            this.db = context;


        }
        public async Task<bool> DeleteCheckOnEntity(int id)
        {

            var flag =await db.Enrollment.AnyAsync(x => x.CourseID == id);
            return flag;
        }
    }
}

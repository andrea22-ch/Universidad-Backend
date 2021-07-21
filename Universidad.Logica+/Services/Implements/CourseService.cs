using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.Logica_.Models;
using Universidad.Logica_.Repositories;
using Universidad.Logica_.Repositories.Implements;

namespace Universidad.Logica_.Services.Implements
{
   public class CourseService:GenericService<Course>, ICourseService
    {

        private readonly ICourseRepository courseRepository;
        public CourseService(ICourseRepository courseRepository):base(courseRepository)
        {
            this.courseRepository = courseRepository;
        }

        public async Task<bool> DeleteCheckOnEntity(int id)
        {
            return await courseRepository.DeleteCheckOnEntity(id);
        }
    }
}

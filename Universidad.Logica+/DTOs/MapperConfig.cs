using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.Logica_.Models;

namespace Universidad.Logica_.DTOs
{
    public class MapperConfig
    {

        public static MapperConfiguration MapperConfiguration()
        {

            return new MapperConfiguration(
                cfg =>
                {
                    cfg.CreateMap<Course, CourseDTO>();
                    cfg.CreateMap<CourseDTO, Course>();
                    cfg.CreateMap<Student, StudentDTO>();
                    cfg.CreateMap<StudentDTO, Student>();
                    cfg.CreateMap<Enrollment, ErrollmentDTO>();
                    cfg.CreateMap<ErrollmentDTO, Enrollment>();

                }
                );
        }
    }
}

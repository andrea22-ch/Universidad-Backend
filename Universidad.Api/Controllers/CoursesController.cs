﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Universidad.Logica_.Models;
using Universidad.Logica_.Repositories.Implements;
using Universidad.Logica_.Services.Implements;
using System.Threading.Tasks;
using AutoMapper;
using Universidad.Logica_.DTOs;
using System.Web.Http.Description;

namespace Universidad.Api.Controllers
{

    //[Authorize]
    public class CoursesController : ApiController
    {
        private readonly CourseService courseService = new CourseService(new CourseRepository(UniversityEntities.create()));
        private IMapper maper;
        public CoursesController()
        {
            this.maper = WebApiApplication.MapperConfiguration.CreateMapper();
        }

        /// <summary>
        ///obtiene  todos los objetos registrados en Course
        /// </summary>
        /// <returns code="200">OK().Devuelve el listados de objetos solicitados</returns>
        [HttpGet]
        [ResponseType(typeof(IEnumerable<CourseDTO>))]
        public async Task<IHttpActionResult>GetAll()
        {
            var courses = await courseService.GetAll();
            var coursesDTO = courses.Select(x => maper.Map<CourseDTO>(x));
            return Ok(coursesDTO);
        }

        /// <summary>
        /// Obtiene un objeto por su id
        /// </summary>
        /// <param name="id">Id Del objeto</param>
        /// <returns code="200">Objeto Course</returns>
        /// <returns code="404">Not Found : No se encuentra el objeto solicitado</returns>
        /// 
        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {
            var course= await courseService.GetById(id);

            if (course == null) return NotFound();
            var courseDTO = maper.Map<CourseDTO>(course);
            return Ok(courseDTO);
        }

        [HttpPost]
        public async Task<IHttpActionResult> Post(CourseDTO courseDTO)
        {
            if (!ModelState.IsValid) 
                return BadRequest(ModelState);

            try
            {
                var course = maper.Map<Course>(courseDTO);
                course = await courseService.Insert(course);
                return Ok();
            }
            catch (Exception e) { return InternalServerError(e); }
            {

            }
       
        }
        [HttpPut]
        public async Task<IHttpActionResult>Put(CourseDTO courseDTO,int id)
        {

            //si el modelo que esta entrando es valido

            if (!ModelState.IsValid)
                { return BadRequest(); }
            //si id del objeto que esta entrando es diferente al id del parametro
            if (courseDTO.CourseID != id)
                return BadRequest();
            var flag= await courseService.GetById(id);
            //si lo que se busco a traves de la variable course_ devuelve nulo
            if (flag== null)
                return  NotFound ();
            try
            {
                //mapea el objeto courseDto al tipo dobjeto Course
                  var course = maper.Map<Course>(courseDTO);
                //await porque sus metodos de  courseService son asymcronos 
                course = await courseService.Update(course);
                return Ok(course);
            }
            catch (Exception e)
            {

                return InternalServerError(e);
            }
        }
        

        [HttpDelete]
        public async Task<IHttpActionResult> Delete(int id)
        {
            var flag = await courseService.GetById(id);
            if (flag == null)
                return NotFound();
            try
            {
                if (!await courseService.DeleteCheckOnEntity(id))
                         await courseService.Delete(id);
                else
                    throw new Exception("LLaves foraneas");
                return Ok();
            }
            catch (Exception e)
            {

                return InternalServerError(e);
            }
            
        }

    }
}

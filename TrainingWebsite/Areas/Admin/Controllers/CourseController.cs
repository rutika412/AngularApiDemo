using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TrainingDatabase;

namespace TrainingWebsite.Areas.Admin.Controllers
{
    public class CourseController : ApiController
    {
        TrainingHouseEntities db = new TrainingHouseEntities();

        [HttpGet]
        public string Get()
        {
            //return db.Courses.AsEnumerable();

            //var context = new TrainingHouseEntities();
            //IEnumerable<Course> course = from c in context.Courses
            //                              select c.Course_Name;

            

            return "EEE";
        }

        /// <summary>
        /// Get courses by Id
        /// </summary>
        /// <param name="courseId"></param>
        /// <returns></returns>
        public Course Get(int courseId)
        {

            Course course = db.Courses.Find(courseId);
            if (course  == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }
            return course;
        }

        /// <summary>
        /// Insert course
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public HttpResponseMessage Post(Course course) {

            if (ModelState.IsValid)
            {
                db.Courses.Add(course);
                db.SaveChanges();
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, course);
                return response;
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }

    }
}

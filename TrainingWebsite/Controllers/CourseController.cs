using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrainingWebsite.Controllers
{
    public class CourseController : Controller
    {
        [HttpGet]
        public string Get()
        {
            //return db.Courses.AsEnumerable();

            //var context = new TrainingHouseEntities();
            //IEnumerable<Course> course = from c in context.Courses
            //                              select c.Course_Name;



            return "EEE";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using studentInformation.Models;

namespace studentInformation.Controllers
{
    public class studentsController : Controller
    {
        // GET: students
        public ActionResult studentInfo()
        {
            students s1 = new students();
            s1.name = "tejpal";
            s1.student_number = "n01194263";
            s1.program_name = "Web Development";

            ViewBag.title = "student info";
            return View(s1);
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Student.Core.IServices;
using Student.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentNew.Web.Controllers
{
    public class Student : Controller
    {

        private readonly IServices _testService;

        public Student(IServices testService)
        {
            _testService = testService;
        }
        public IActionResult Loginpage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Loginpage(StudentLogin Login1)
        {
            var value = _testService.StudentLogin(Login1);
            if (value != null)
            {
                return View("create");
            }
            return View();
        }
        public IActionResult create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Createdetails(Studententry ob)
        {

            var model = _testService.CreateDetails(ob);
            return View();
        }
        public ActionResult Studentshow()
        {
            var value = _testService.StudentDisplay();
            return View(value);
        }
    }
}

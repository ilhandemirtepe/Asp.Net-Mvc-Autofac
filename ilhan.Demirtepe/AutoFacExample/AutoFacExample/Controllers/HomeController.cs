using AutoFacExample.IRepository;
using AutoFacExample.Models;
using AutoFacExample.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoFacExample.Controllers
{
    public class HomeController : Controller
    {
        IStudent _student;


       
        public HomeController(IStudent student)
        {
            _student = student;
   
        }
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult List()
        {
            return Json(_student.GetAllStudent(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult Add(Student student)
        {
            return Json(_student.AddStudent(student), JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetbyID(string id)
        {
           
            return Json(_student.GetStudentByID(Convert.ToInt32(id)), JsonRequestBehavior.AllowGet);
        }
        public JsonResult Update(Student student)
        {
            return Json(_student.UpdateStudent(student), JsonRequestBehavior.AllowGet);
        }
        public JsonResult Delete(string id)
        {
            return Json(_student.DeleteStudent(Convert.ToInt32(id)), JsonRequestBehavior.AllowGet);
        }

    }
}
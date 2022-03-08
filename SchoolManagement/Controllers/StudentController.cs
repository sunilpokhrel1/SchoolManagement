using SchoolManagement.Model;
using SchoolManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagement.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepo _repo;
        public StudentController()
        {
            _repo = new StudentRepo ();
        }
        // GET: Student
        public ActionResult Index()
        {
              return View(_repo.GetList());
            // return View();
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View(_repo.GetById(id));
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(Student data)
        {
            try
            {
                _repo.Add(data);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {

            return View(_repo.GetById(id));
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(Student data)
        {
            try
            {

                _repo.Update(data);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View(_repo.GetById(id));
        //}

        // POST: Student/Delete/5
        [HttpPost]
        public ActionResult Delete( int id)
        {
            try
            {
               // _repo.GetById(id)
                _repo.Delete(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

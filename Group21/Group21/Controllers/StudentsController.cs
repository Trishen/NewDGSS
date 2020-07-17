using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Group21.Models;


namespace Group21.Controllers
{
    public class StudentsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Students
        public ActionResult Index()
        {
            return View(db.Student.ToList());
        }

        // GET: Students/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Student.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // GET: Students/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StID,StudentName,StudentSurname,StudentGender,StudentAddress,StudentTown,StudentGrade,StudentCourse,StudentContact,StudentEmail,StudentPassword,ParentName,ParentId,ParentContact,StudentAllowReg")] Student student, HttpPostedFileBase StudentBirthCertURL , HttpPostedFileBase StudentReportURL , HttpPostedFileBase StudentProofResURL , HttpPostedFileBase StudentPermitURL)
        {
           
              
                    StudentBirthCertURL.SaveAs(Server.MapPath("/") + "/Content/" + StudentBirthCertURL.FileName);
                    student.StudentBirthCertURL = StudentBirthCertURL.FileName;
               

                StudentReportURL.SaveAs(Server.MapPath("/") + "/Content/" + StudentReportURL.FileName);
                student.StudentReportURL = StudentReportURL.FileName;

                StudentProofResURL.SaveAs(Server.MapPath("/") + "/Content/" + StudentProofResURL.FileName);
                student.StudentProofResURL = StudentProofResURL.FileName;

                StudentPermitURL.SaveAs(Server.MapPath("/") + "/Content/" + StudentPermitURL.FileName);
                student.StudentPermitURL = StudentPermitURL.FileName;

                db.Student.Add(student);
                db.SaveChanges();
                return RedirectToAction("Index");
            
        }

        // GET: Students/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Student.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StID,StudentName,StudentSurname,StudentGender,StudentAddress,StudentTown,StudentGrade,StudentCourse,StudentContact,StudentEmail,StudentPassword,ParentName,ParentId,ParentContact,StudentBirthCertURL,StudentReportURL,StudentProofResURL,StudentPermitURL,StudentAllowReg")] Student student)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }

        // GET: Students/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Student.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Student student = db.Student.Find(id);
            db.Student.Remove(student);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

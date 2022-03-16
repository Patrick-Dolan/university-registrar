using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using UniversityRegistrar.Models;

namespace UniversityRegistrar.Controllers
{
  public class StudentsController : Controller
  {
    private readonly UniversityRegistrarContext _db;
    public StudentsController(UniversityRegistrarContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Students.ToList());
    }

    public ActionResult Create()
    {
      ViewBag.CourseId = new SelectList(_db.Courses, "CourseId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Student student, int CourseId)
    {
      _db.Students.Add(student);
      _db.SaveChanges();
      if (CourseId != 0)
      {
        _db.CourseStudents.Add(new CourseStudent() {CourseId = CourseId, StudentId = student.StudentId});
        _db.SaveChanges();
      }
      return RedirectToAction("Index");
    }

    public ActionResult Edit(int id)
    {
      Student foundStudent = _db.Students.FirstOrDefault(student => student.StudentId == id);
      ViewBag.CourseId = new SelectList(_db.Courses, "CourseId", "Name");
      return View(foundStudent);
    }

    [HttpPost]
    public ActionResult Edit(Student student, int CourseId)
    {
      if (CourseId != 0)
      {
        _db.CourseStudents.Add(new CourseStudent() {CourseId = CourseId, StudentId = student.StudentId});
      }
      _db.Entry(student).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      Student foundStudent = _db.Students.FirstOrDefault(student => student.StudentId == id);
      return View(foundStudent);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Student foundStudent = _db.Students.FirstOrDefault(student => student.StudentId == id);
      _db.Students.Remove(foundStudent);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Student foundStudent = _db.Students
        .Include(student => student.JoinEntities)
        .ThenInclude(join => join.Course)
        .FirstOrDefault(student => student.StudentId == id);
      return View(foundStudent);
    }

    //TODO Add "addCourse" get and post & "deleteCourse
  }
}
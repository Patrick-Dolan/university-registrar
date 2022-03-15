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
      return View();
    }

    [HttpPost]
    public ActionResult Create(Student student)
    {
      _db.Students.Add(student);
      _db.SaveChanges();
      //TODO add setup for many to many connection for courses
      return RedirectToAction("Index");
    }

    public ActionResult Edit(int id)
    {
      Student foundStudent = _db.Students.FirstOrDefault(student => student.StudentId == id);
      return View(foundStudent);
    }

    [HttpPost]
    public ActionResult Edit(Student student)
    {
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
  }
}
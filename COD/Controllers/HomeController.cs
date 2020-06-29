using COD.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace COD.Controllers
{
    public class HomeController : Controller
    {
        Models.AppDbContext db = new Models.AppDbContext();
        public ActionResult Index()
        {
            return View(db.Courses.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Course c)
        {
            if (ModelState.IsValid)
            {
                using (var ctx = new AppDbContext())
                {
                    ctx.Courses.Add(c);
                    ctx.SaveChanges();
                }
            }
            return View();
        }
        
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var ctx = new AppDbContext();
            var course = ctx.Courses.Find(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }

        [HttpPost]
        [ActionName("Edit")]
        public async Task<ActionResult> EditData(Course c)
        {
            var ctx = new AppDbContext();
            var course = await ctx.Courses.FindAsync(c.Id);
            if (course != null)
            {
                course.Author = c.Author;
                course.Cost = c.Cost;
                course.Name = c.Name;
                course.Duration = c.Duration;
                await ctx.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return HttpNotFound();
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            using (var ctx = new AppDbContext())
            {
                var c = ctx.Courses.Find(id);
                if (c != null)
                {
                    ctx.Entry<Course>(c).State = EntityState.Deleted;
                    ctx.SaveChanges();
                }
                else
                {
                    return HttpNotFound();
                }
            }
            return RedirectToAction(nameof(Index));
        }

        public ActionResult List()
        {
            return View();
        }
    }
}
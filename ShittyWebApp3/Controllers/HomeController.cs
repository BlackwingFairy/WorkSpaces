using ShittyWebApp3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ShittyWebApp3.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();

        public ActionResult Index()
        {
            
            List<WorkSpace> wsList = context.WorkSpaces.ToList();
            return View(wsList);
        }
        
        public ActionResult WorkSp(string group)
        {
            ViewBag.Group = group;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateWsp([Bind(Include = "Id,GroupName")] WorkSpace workSpace)
        {
            if (ModelState.IsValid)
            {
                context.WorkSpaces.Add(workSpace);
                await context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(workSpace);
        }

        public ActionResult CreateWsp()
        {
            return View();
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
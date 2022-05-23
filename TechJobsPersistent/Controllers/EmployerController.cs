using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechJobsPersistent.Data;
using TechJobsPersistent.Models;
using TechJobsPersistent.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobsPersistent.Controllers
{
    public class EmployerController : Controller
    {
        private JobDbContext context;

        public EmployerController(JobDbContext dbContext)
        {
            context = dbContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Employer> employer = context.Employers.ToList();
            return View(employer);
        }

        public IActionResult Add()
        {
            Employer employer = new Employer();
            return View(employer);
        }

        public IActionResult ProcessAddEmployerForm(Employer employer)
        {
            if (ModelState.IsValid)
            {
                context.Employers.Add(employer);
                context.SaveChanges();
                return Redirect("/Employer/");
            }

            return View("Add", employer);
        }

        public IActionResult About(int id)
        {
            List<Employer> employer = context.Employers
                .Where(j => j.Id == id)
                .Include(j => j.Name)
                .Include(j => j.Location)
                .ToList();

            return View(employer);
        }
    }
}

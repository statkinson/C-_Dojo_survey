using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dojo_survey.Models;
using Microsoft.EntityFrameworkCore;

namespace dojo_survey.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController (MyContext context) {
            dbContext = context;
        }
        public IActionResult Index()
        {
            dbContext.Add(dish);
            dbContext.SaveChanges();
            return View();
        }
        [HttpPost("/results")]
        public IActionResult results(User user)
        {
            if (ModelState.IsValid)
            {
                return View(user);
            }
            else
            {
                return View("Index");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

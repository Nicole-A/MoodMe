using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MoodMe.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MoodMe.Controllers
{
    public class SleepController : Controller
    {
        private readonly ApplicationDbContext context;

        public SleepController(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index()
        {
            return View(context.Sleeps.ToList());
        }

        [HttpPost]
        public IActionResult Submit()
        {
            return Redirect("/Mood");
        }
    }
}

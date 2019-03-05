using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MoodMe.Data;

namespace MoodMe.Controllers
{
    public class FoodController : Controller
    {
        private readonly ApplicationDbContext context;

        public FoodController(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index()
        {
            return View(context.Foods.ToList());
        }

        [HttpPost]
        public IActionResult Submit()
        {
            return Redirect("/Tableau");
        }
    }
}
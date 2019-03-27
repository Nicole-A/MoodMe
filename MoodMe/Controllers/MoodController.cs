using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MoodMe.Data;
using MoodMe.Models;

namespace MoodMe.Controllers
{
    public class MoodController : Controller 
    {
        private readonly ApplicationDbContext context;

        public MoodController(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }

        //public IActionResult Index()
        //{
        //    return View(context.Moods.ToList());
        //}

        [HttpPost]
        public IActionResult Submit()
        {
            return View();
        }
    }
}
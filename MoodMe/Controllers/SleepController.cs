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
        public IActionResult Submit(/*Sleep sleep*/)
        {
            ////This is where we query off the database to see if an entry already exists or not
            //Entry entry = context.entries.single(entry => entry.UserID == UserID && entry.Date == currentDate);

            ////check if it exists
            //if (entry = null)
            //{
            //    //since it doesn't exist, then we create it
            //    Entry newEntry = new Entry
            //    {
            //        UserID = '',
            //        Date = now(),
            //        SleepID = sleep.ID
            //    };

            //    context.entries.add(newEntry);
            //} else
            //{
            //    //since it's already created, we simply modify the existing one
            //    entry.sleepid = sleep.sleepid;
            //}

            //context.SaveChanges();
            return Redirect("/Mood");
        }
    }
}

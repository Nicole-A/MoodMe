using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MoodMe.Data;
using MoodMe.Models;
using MoodMe.ViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MoodMe.Controllers
{
    public class SleepController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public SleepController(ApplicationDbContext context,
            UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            SelectSleepViewModel selectSleepViewModel = new SelectSleepViewModel(_context.Sleeps.ToList());
            return View(selectSleepViewModel);
        }

        [HttpPost]
        public IActionResult Submit(int SleepId)
        {
            Sleep newSleep = _context.Sleeps.Single(s => s.Id == SleepId);
            UserSleep userSleep = new UserSleep
            {
                UserId = _userManager.GetUserId(User),
                Sleep = newSleep
            };
            _context.UserSleeps.Add(userSleep);
            _context.SaveChanges();
            return Redirect("/Mood");
        } 
    }
}
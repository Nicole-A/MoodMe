using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MoodMe.Data;
using MoodMe.Models;
using MoodMe.ViewModel;

namespace MoodMe.Controllers
{
    public class MoodController : Controller 
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public MoodController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            SelectMoodViewModel selectMoodViewModel = new SelectMoodViewModel(_context.Moods.ToList());
            return View(selectMoodViewModel);
        }
        

        [HttpPost]
        public IActionResult Submit(int MoodId)
        {
            Mood newMood = _context.Moods.Single(s => s.Id == MoodId);
            UserMood userMood = new UserMood
            {
                UserId = _userManager.GetUserId(User),
                Mood = newMood
            };
            _context.UserMoods.Add(userMood);
            _context.SaveChanges();

            return Redirect("/Food");
        }
    }
}
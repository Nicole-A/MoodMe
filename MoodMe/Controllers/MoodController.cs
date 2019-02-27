using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MoodMe.Data;
using MoodMe.ViewModels;
using MoodMe.Models;
using Microsoft.AspNetCore.Identity;
using MoodMe.Areas.Identity.Data;

namespace MoodMe.Controllers
{
    public class MoodController : Controller
    {
        private readonly MoodMeContext _context;
        private readonly UserManager<MoodMeUser> _userManager;

        public MoodController(MoodMeContext context, UserManager<MoodMeUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View(_context.Moods.ToList());
        }

        [HttpPost]
        public IActionResult SubmitMood(Mood mood)
        {
           /* UserMoods userMoods = new UserMoods
            {
                MoodMeUser = User,
                Mood = mood
            }; */

            /*_context.UserMoods.Add */
            return Redirect("/Food");
        } 

    }
}
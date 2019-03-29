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
    public class FoodController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public FoodController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            SelectFoodViewModel selectFoodViewModel = new SelectFoodViewModel(_context.Foods.ToList());
            return View(selectFoodViewModel);
        }

        [HttpPost]
        public IActionResult Submit(int FoodId)
        {
            Food newFood = _context.Foods.Single(s => s.Id == FoodId);
            UserFood userFood = new UserFood
            {
                UserId = _userManager.GetUserId(User),
                Food = newFood
            };
            _context.UserFoods.Add(userFood);
            _context.SaveChanges();
            return Redirect("/Tableau");
        }
    }
}
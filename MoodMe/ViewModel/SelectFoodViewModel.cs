using Microsoft.AspNetCore.Mvc.Rendering;
using MoodMe.Data.Migrations;
using MoodMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoodMe.ViewModel
{
    public class SelectFoodViewModel
    {
        public List<SelectListItem> Foods { get; set; }
        public int FoodId { get; set; }

        public SelectFoodViewModel(IEnumerable<Food> foods)
        {
            Foods = new List<SelectListItem>();

            foreach (Food food in foods)
            {
                Foods.Add(new SelectListItem
                {
                    Value = food.Id.ToString(),
                    Text = food.Name.ToString()
                });
            }
        }
       
    }
}

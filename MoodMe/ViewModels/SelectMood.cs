using Microsoft.AspNetCore.Mvc.Rendering;
using MoodMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoodMe.ViewModels
{
    public class SelectMood
    {
        public List<SelectListItem> Moods { get; set; }

        public SelectMood(IEnumerable<Mood> moods)
        {
            Moods = new List<SelectListItem>();

            foreach (Mood mood in moods)
            {
                Moods.Add(new SelectListItem
                {
                    Value = mood.Id.ToString(),
                    Text = mood.Name.ToString()
                });
            }
        }
        public SelectMood() { }
    }
}

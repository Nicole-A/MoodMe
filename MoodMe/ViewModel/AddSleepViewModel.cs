using Microsoft.AspNetCore.Mvc.Rendering;
using MoodMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoodMe.ViewModel
{
    public class AddSleepViewModel
    {
        public List<SelectListItem> Sleeps { get; set; }

        public string Sleep { get; set; }
        public int SleepId { get; set; }

        
        public AddSleepViewModel(IEnumerable<Sleep> sleeps)
        {
            Sleeps = new List<SelectListItem>();

            foreach (Sleep sleep in sleeps)
            {
                Sleeps.Add(new SelectListItem
                {
                    Value = sleep.Id.ToString(),
                    Text = sleep.Hours.ToString()
                });
            }
        }

        public AddSleepViewModel() { }
    }
}

using MoodMe.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoodMe.Models
{
    public class UserMoods
    {
        public string UserID { get; set; }
        public MoodMeUser MoodMeUser { get; set; }
        public int MoodID { get; set; }
        public Mood Mood { get; set; }
    }
}

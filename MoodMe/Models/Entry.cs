using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoodMe.Models
{
    public class Entry
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MoodId { get; set; }
        public int SleepId { get; set; }
        public int FoodId { get; set; }
    }
}

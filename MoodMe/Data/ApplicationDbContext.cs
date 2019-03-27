using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MoodMe.Models;

namespace MoodMe.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Mood> Moods { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Sleep> Sleeps { get; set; }
        public DbSet<UserFood> UserFoods { get; set; }
        public DbSet<UserMood> UserMoods { get; set; }
        public DbSet<UserSleep> UserSleeps { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}

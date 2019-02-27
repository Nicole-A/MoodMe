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
        public DbSet<UserMoods> UserMoods { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}

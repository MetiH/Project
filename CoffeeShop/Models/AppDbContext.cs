using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        internal object ObjectStateManager;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Coffee> coffees { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
    }
}

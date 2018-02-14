using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserSearch.Models;
using Microsoft.EntityFrameworkCore;

namespace UserSearch.Data
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        // Override table name
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
        }
    }
}

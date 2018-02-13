using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace UserSearch.Models
{
    public class UserSearchContext : DbContext
    {
        public UserSearchContext (DbContextOptions<UserSearchContext> options)
            : base(options)
        {
        }

        public DbSet<UserSearch.Models.User> User { get; set; }
    }
}

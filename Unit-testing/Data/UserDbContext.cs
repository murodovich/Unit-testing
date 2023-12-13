using Microsoft.EntityFrameworkCore;
using Unit_testing.Entities;

namespace Unit_testing.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) 
            : base(options)
            { }
        public DbSet<User> Users { get; set; }

    }
}

using Microsoft.EntityFrameworkCore;
using ReferMeApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReferMeApi.Persistence
{
    public class ReferMeDbContext : DbContext
    {
        public ReferMeDbContext(DbContextOptions<ReferMeDbContext> options)
            : base(options)
        {

        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Password> Passwords { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<UserStatus> UserStatuses { get; set; }
        public DbSet<User> Users { get; set; }

    }
}

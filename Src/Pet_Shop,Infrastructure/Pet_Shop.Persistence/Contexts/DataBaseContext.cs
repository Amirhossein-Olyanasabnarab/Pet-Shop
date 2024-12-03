using Microsoft.EntityFrameworkCore;
using Pet_Shop.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Shop.Persistence.Contexts
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext()
        {
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserInRole> UserInRoles { get; set; }
    }
}

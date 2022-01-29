using AlkemyProyecto.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlkemyProyecto.Data
{
    public class MyDbContext : DbContext
    {

        public MyDbContext (DbContextOptions<MyDbContext>options) : base(options)
        {

        }

        public DbSet<User> User { get; set; }
        public DbSet<Posts> Posts { get; set; }
        public DbSet<Comments> Comments { get; set; }
    }
}

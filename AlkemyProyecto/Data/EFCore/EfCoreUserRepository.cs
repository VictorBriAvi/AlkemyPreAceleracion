using AlkemyProyecto.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlkemyProyecto.Data.EFCore
{
    public class EfCoreUserRepository : EfCoreRepository<User, MyDbContext>
    {
        public EfCoreUserRepository(MyDbContext context) : base(context)
        {

        }

        public DbSet<Posts> Posts { get; set; }
        public DbSet<Comments> Comments { get; set; }

    }
}

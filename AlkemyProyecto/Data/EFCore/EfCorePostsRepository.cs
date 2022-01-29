using AlkemyProyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlkemyProyecto.Data.EFCore
{
    public class EfCorePostsRepository : EfCoreRepository<Posts, MyDbContext>
    {
        public EfCorePostsRepository(MyDbContext context) : base(context)
        {

        }
    }
    
}

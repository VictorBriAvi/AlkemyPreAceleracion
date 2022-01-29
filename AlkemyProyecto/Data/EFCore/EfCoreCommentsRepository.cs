using AlkemyProyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlkemyProyecto.Data.EFCore
{
    public class EfCoreCommentsRepository : EfCoreRepository<Comments, MyDbContext>
    {
     
        public EfCoreCommentsRepository(MyDbContext context) : base(context)
        {

        }
    }
}

using AlkemyProyecto.Data.EFCore;
using AlkemyProyecto.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlkemyProyecto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : MyDbController<Posts, EfCorePostsRepository>
    {
        public PostsController(EfCorePostsRepository repository) : base(repository)
        {

        }
    }
}

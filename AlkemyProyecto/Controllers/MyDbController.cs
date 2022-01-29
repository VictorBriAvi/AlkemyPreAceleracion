using AlkemyProyecto.Data;
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
    public abstract class MyDbController<TEntity, TRepository> : ControllerBase

        where TEntity : class,IEntity
        where TRepository : IRepository<TEntity>
    {
        private readonly TRepository repository;

        public MyDbController(TRepository repository)
        {
            this.repository = repository;
        }

        //GET : api/[controller]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>>Get()
        {
            return await repository.GetAll();
        }

        //Get : api/[controller]/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> Get(int id)
        {
            var user = await repository.Get(id);
            if (user == null)
            {
                return NotFound();
            }
            return user;
        }

        //PUT : api/[controller]/5
        [HttpPut("{id}")]

        public async Task<IActionResult> Put(int id, TEntity user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            await repository.Update(user);
            return NoContent();
        }

        //POST : api/[controller]

        [HttpPost]
        public async Task<ActionResult<TEntity>> Post (TEntity user)
        {
            await repository.Add(user);
            return CreatedAtAction("Get", new { id = user.Id }, user);
        }

        //DELETE: api/[controller]/5

        [HttpDelete("{id}")]
        
        public async Task<ActionResult<TEntity>> Delete(int id)
        {
            var user = await repository.Delete(id);
            if (user == null)
            {
                return NotFound();
            }
            return user;
        }

    }
}

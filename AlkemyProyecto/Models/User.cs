using AlkemyProyecto.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlkemyProyecto.Models
{
    public class User : IEntity
    {

        public int Id { get; set; }
        [Required]
        [StringLength(60,MinimumLength =3)]
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public ICollection<Posts> Posts { get; set; }

        public ICollection<Comments> Comments { get; set; }
    }
}

using AlkemyProyecto.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlkemyProyecto.Models
{
    public class Comments : IEntity
    {

        [Key]
        public int Id { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }
        public User User { get; set; }
    }
}

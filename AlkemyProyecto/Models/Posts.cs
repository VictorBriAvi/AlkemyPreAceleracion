﻿using AlkemyProyecto.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlkemyProyecto.Models
{
    public class Posts :IEntity
    {

        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set;}
        public User User { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LojasAPI.Model
{
    public class Loja
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(16)]
        public string Name { get; set; }
        [Required(ErrorMessage ="E-mail is required")]
        public string Email { get; set; }



    }
}

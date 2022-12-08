using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LojasAPI.Model
{
    public class Compra
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [ForeignKey("Usuario")]
        public int Id_usuario { get; set; }
        [ForeignKey("Loja")]
        public int Id_loja { get; set; }
    }
}

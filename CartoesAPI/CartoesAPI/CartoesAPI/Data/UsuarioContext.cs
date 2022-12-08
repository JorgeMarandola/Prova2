using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojasAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace LojasAPI.Data
{
    public class UsuarioContext : DbContext
    {
        public UsuarioContext(DbContextOptions<UsuarioContext> opt) : base(opt)
        { }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}

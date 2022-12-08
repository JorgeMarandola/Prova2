using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojasAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace LojasAPI.Data
{
    public class LojaContext : DbContext
    {
        public LojaContext(DbContextOptions<LojaContext> opt) : base(opt)
        { }

        public DbSet<Loja> Lojinhas { get; set; }
    }
}

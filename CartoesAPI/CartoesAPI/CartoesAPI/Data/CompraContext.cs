using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojasAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace LojasAPI.Data
{
    public class CompraContext : DbContext
    {
        public CompraContext(DbContextOptions<CompraContext> opt) : base(opt)
        { }

        public DbSet<Compra> Comprinhas { get; set; }
    }
}

using LojasAPI.Data;
using LojasAPI.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojasAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompraController : Controller
    {
        private CompraContext _context;

        public CompraController(CompraContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Compra> GetCompra()
        {
            return _context.Comprinhas;
        }
        [HttpPost]
        public IActionResult AddCompras([FromBody] Compra compra)
        {
            _context.Comprinhas.Add(compra);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetComprasById), new { Id = compra.Id }, compra);
        }

        [HttpGet("{id}")]
        public IActionResult GetComprasById(int id)
        {
            Compra compra = _context.Comprinhas.FirstOrDefault(compra => compra.Id == id);
            if (compra != null)
            {
                return Ok(compra);
            }
            return NotFound();
        }

    }
}

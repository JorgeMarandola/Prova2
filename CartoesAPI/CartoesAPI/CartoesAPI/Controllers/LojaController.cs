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
    public class LojaController : Controller
    {
        private LojaContext _context;

        public LojaController(LojaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Loja> GetLojas()
        {
            return _context.Lojinhas;
        }
        [HttpPost]
        public IActionResult AddLojas([FromBody] Loja loja)
        {
            _context.Lojinhas.Add(loja);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetLojasById), new { Id =  loja.Id}, loja);
        }

        [HttpGet("{id}")]
        public IActionResult GetLojasById(int id)
        {
            Loja loja = _context.Lojinhas.FirstOrDefault(loja => loja.Id == id);
            if(loja != null)
            {
                return Ok(loja);
            }
            return NotFound();
        }

    }
}

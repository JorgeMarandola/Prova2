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
    public class UsuarioController : Controller
    {
        private UsuarioContext _context;

        public UsuarioController(UsuarioContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Usuario> GetUsuarios()
        {
            return _context.Usuarios;
        }
        [HttpPost]
        public IActionResult AddUsuarios([FromBody] Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetLojasById), new { Id = usuario.Id }, usuario);
        }

        [HttpGet("{id}")]
        public IActionResult GetLojasById(int id)
        {
            Usuario usuario = _context.Usuarios.FirstOrDefault(usuario => usuario.Id == id);
            if (usuario != null)
            {
                return Ok(usuario);
            }
            return NotFound();
        }

    }
}

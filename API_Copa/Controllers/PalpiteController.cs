using System.Collections.Generic;
using System.Linq;
using api.Models;
using API_Copa.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [ApiController]
    [Route("api/palpite")]
    public class PalpiteController : ControllerBase
    {
        private readonly Context _context;
        public PalpiteController(Context context) =>
            _context = context;

        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Palpite palpite)
        {
            palpite.SelecaoA = _context.Selecoes.Find(palpite.SelecaoA.Id);
            palpite.SelecaoB = _context.Selecoes.Find(palpite.SelecaoB.Id);
            _context.Palpites.Add(palpite);
            _context.SaveChanges();
            return Created("", palpite);
        }

        [HttpGet]
        [Route("listar")]
        public IActionResult Listar()
        {
            List<Palpite> palpites = _context.Palpites.Include(x => x.SelecaoA).Include(x => x.SelecaoB).Include(x => x.PlacarA).Include(x => x.PlacarB).ToList();
            return palpites.Count != 0 ? Ok(palpites) : NotFound();
        }
    }
}
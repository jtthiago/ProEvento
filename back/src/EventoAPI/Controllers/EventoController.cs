using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventoAPI.Data;
using EventoAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EventoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
       
        
        
       
        
        private readonly DataContext _context;

        public EventosController(DataContext context)
        {
            _context = context;
           
            
          
        }

        [HttpGet]
        public  IEnumerable<Evento> Get()
        {
            return _context.Eventos;
        }

        [HttpGet("{id}")]

        public IEnumerable<Evento> GetById(int id)
        {
            return _context.Eventos.Where(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "value";   
        }

        [HttpDelete("{id}")]
        public string Put(int id)
        {
            return "value";   
        }

        
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return "value";   
        }
    }
}

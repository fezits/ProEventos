using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{

    private readonly DataContext _context;
    //inicializa o campo a partir do parametro
    public EventoController(DataContext context)
    {
      _context = context;
    }
 
    [HttpGet(Name = "GetEvento")]
    public IEnumerable<Evento> Get()
    {
       return _context.Eventos;
    }

    [HttpGet("{id}")]
    public Evento GetById(int id)
    {
       return _context.Eventos.FirstOrDefault(
          evento => evento.EventoId == id
          );
    }

    [HttpPost(Name = "PostEvento")]
    public string Post()
    {
       return "Evento de post";
    }

    [HttpPut("{id}")]
    public string Put(int id)
    {
       return $"Evento de put {id}";
    }

    [HttpDelete("{id}")]
    public string Delete(int id)
    {
       return $"Evento de Delete {id}";
    }
    
}

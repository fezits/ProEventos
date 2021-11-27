using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
   public IEnumerable<Evento> _evento = new Evento[]{
      new Evento(){
         EventoId = 1,
         Local = "Floripa",
         Tema = "Angular 11 e .NET5",
         Lote = "1º Lote",
         QtdPessoas = 240,
         DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
         ImagemURL = "Imagem1.png"
      },
      new Evento(){
         EventoId = 2,
         Local = "São Paulo",
         Tema = "Festa",
         Lote = "2º Lote",
         QtdPessoas = 240,
         DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
         ImagemURL = "222.png"
      }
      
       
    };
    

    
    public EventoController()
    {
      
    }

    [HttpGet(Name = "GetEvento")]
    public IEnumerable<Evento> Get()
    {
       return _evento;
    }

    [HttpGet("{id}")]
    public IEnumerable<Evento> GetById(int id)
    {
       return _evento.Where(evento => evento.EventoId == id);
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

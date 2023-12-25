using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventoController : ControllerBase
    {

        public EventoController()
        {

        }
        public IEnumerable<Evento> _evento = new Evento[]{
            new Evento {
                EventoId = 1,
                Local = "São Paulo",
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                Tema = "Angular 11 e .NET 5",
                QtdPessoas = 250,
                Lote = "Primeiro Lote",
                ImagemURL = "URL da imagem"
            },
            new Evento {
                EventoId = 2,
                Local = "São Paulo",
                DataEvento = DateTime.Now.AddDays(4).ToString("dd/MM/yyyy"),   
                Tema = "Angular 11 é o futuro",
                QtdPessoas = 150,
                Lote = "Segundo Lote",
                ImagemURL = "URL da imagem"
            }
        };

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete id = {id}";
        }
        
    }
}

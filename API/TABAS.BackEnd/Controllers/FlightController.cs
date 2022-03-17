using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TABAS.BackEnd.Models;

namespace TABAS.BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        [HttpGet("{id}")]
        public string Get(int id)
        {
            //Codigo para leer de la base de datos.
            return id switch
            {
                1 => "Ivan",
                2 => "Curso",
                _ => throw new NotSupportedException("el id no es válido")
            };
        }
        [HttpPost]
        public string Post(FlightDto flight)
        {
            //Guardar perfil en la base de datos.
            return "pasó";
        }
    }
}

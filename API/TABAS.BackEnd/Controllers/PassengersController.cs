﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TABAS.BackEnd.Models;

namespace TABAS.BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengersController : ControllerBase
    {
        [HttpGet("{id}")]
        public string Get(int id)
        {
            //Codigo para leer de la base de datos.
            return id switch
            {
                1 => "Anthony",
                2 => "Montero",
                _ => throw new NotSupportedException("el id no es válido")
            };
        }
        [HttpPost]
        public string Post(PassengersDto passenger)
        {
            //Guardar perfil en la base de datos.
            return "pasó";
        }
    }
}
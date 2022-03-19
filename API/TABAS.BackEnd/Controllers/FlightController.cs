﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TABAS.BackEnd.Models;

namespace TABAS.BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        private static string jsonFileName = "Flights.json";

        /// <summary>
        /// This function gets the data of a flight.
        /// </summary>
        /// <param name="id"> The flight number </param>
        /// <returns> Returns a flight object </returns>
        /// <exception cref="NotSupportedException"></exception>
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return id switch
            {
                1 => "Ivan",
                2 => "Curso",
                _ => throw new NotSupportedException("el id no es válido")
            };
        }

        /// <summary>
        /// This function saves the data of a flight.
        /// </summary>
        /// <param name="flight"> The data of a flight </param>
        /// <returns></returns>
        [HttpPost]
        public void Post(FlightDto flight)
        {
            //JsonManagement.SerializeJsonFile(flight, jsonFileName);
        }
    }
}

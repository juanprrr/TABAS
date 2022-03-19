using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TABAS.BackEnd.Models;

namespace TABAS.BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirplaneController : ControllerBase
    {
        private static string jsonFileName = "Airplanes.json";

        /// <summary>
        /// This function gets the data of an airplane.
        /// </summary>
        /// <param name="id"> The identifier of the airplane </param>
        /// <returns> Returns an airplane object </returns>
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
        /// This function saves the data of an airplane.
        /// </summary>
        /// <param name="airplane"> The data of an airplane </param>
        [HttpPost]
        public void Post(AirplaneDto airplane)
        {
            //JsonManagement.SerializeJsonFile(airplane, jsonFileName);
        }
    }
}

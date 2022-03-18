using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TABAS.BackEnd.Models;

namespace TABAS.BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuitcaseController : ControllerBase
    {
        private static string jsonFileName = "Suitcases.json";

        /// <summary>
        /// This function gets the data of a suitcase.
        /// </summary>
        /// <param name="id"> The suitcase number </param>
        /// <returns> Returns a suitcase object </returns>
        /// <exception cref="NotSupportedException"></exception>
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return id switch
            {
                1 => "1",
                2 => "40",
                _ => throw new NotSupportedException("el id no es válido")
            };
        }

        /// <summary>
        /// This function saves the data of a suitcase.
        /// </summary>
        /// <param name="suitcase"> The data of a suitcase </param>
        [HttpPost]
        public void Post(SuitcaseDto suitcase)
        {
            JsonManagement.SerializeJsonFile(suitcase, jsonFileName);
        }
    }
}

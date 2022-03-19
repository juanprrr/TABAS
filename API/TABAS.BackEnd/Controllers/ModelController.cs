using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TABAS.BackEnd.Models;

namespace TABAS.BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelController : ControllerBase
    {
        private static string jsonFileName = "Models.json";

        /// <summary>
        /// This function gets the data of an airplane model.
        /// </summary>
        /// <param name="id"> The name of an airplane model </param>
        /// <returns> Returns a model object </returns>
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
        /// This function saves the data of an airplane model.
        /// </summary>
        /// <param name="model"> The data of an airplane model </param>
        [HttpPost]
        public void Post(ModelDto model)
        {
            //JsonManagement.SerializeJsonFile(model, jsonFileName);
        }
    }
}

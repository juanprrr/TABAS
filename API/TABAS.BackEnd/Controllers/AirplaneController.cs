using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TABAS.BackEnd.Models;

namespace TABAS.BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirplaneController : ControllerBase
    {
        private static string jsonFilePath = @".\JSONs\Airplanes.json";

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
            AirplaneDto[] jsonFromFile = DeserializeJsonFile();

            JsonManagement.SerializeJsonFile(airplane, jsonFromFile, jsonFilePath);
        }

        /// <summary>
        /// This function deserializes a json object.
        /// </summary>
        /// <returns> Returns a json list from a file </returns>
        public static AirplaneDto[] DeserializeJsonFile()
        {
            string jsonFromFile = JsonManagement.GetJsonFromFile(jsonFilePath);

            AirplaneDto[] jsonObject = JsonConvert.DeserializeObject<AirplaneDto[]>(jsonFromFile);

            return jsonObject;
        }
    }
}

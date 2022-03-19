using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TABAS.BackEnd.Models;

namespace TABAS.BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengerController : ControllerBase
    {
        private static string jsonFilePath = @".\JSONs\Passengers.json";

        /// <summary>
        /// This function gets the data of a passenger.
        /// </summary>
        /// <param name="id"> The passenger´s identifier </param>
        /// <returns> Returns a passenger object </returns>
        /// <exception cref="NotSupportedException"></exception>
        [HttpGet("{id}")]
        public object Get(int id)
        {
            PassengerDto[] jsonFromFile = DeserializeJsonFile();

            object response = "";

            foreach (var jsonObject in jsonFromFile )
            {
                if(jsonObject.Id == id)
                {
                    response = jsonObject;
                }
            }

            /*
            return id switch
            {
                1 => "Anthony",
                2 => "Montero",
                _ => throw new NotSupportedException("el id no es válido")
            };
            */

            return response;
        }

        /// <summary>
        /// This function saves the data of a passenger.
        /// </summary>
        /// <param name="passenger"> The data of a passengers </param>
        [HttpPost]
        public void Post(PassengerDto passenger)
        {
            PassengerDto[] jsonFromFile = DeserializeJsonFile();

            JsonManagement.SerializeJsonFile(passenger, jsonFromFile, jsonFilePath);
        }

        /// <summary>
        /// This function deserializes a json object.
        /// </summary>
        /// <returns> Returns a json list from a file </returns>
        public static PassengerDto[] DeserializeJsonFile()
        {
            string jsonFromFile = JsonManagement.GetJsonFromFile(jsonFilePath);

            PassengerDto[] jsonObject = JsonConvert.DeserializeObject<PassengerDto[]>(jsonFromFile);

            return jsonObject;
        }
    }
}

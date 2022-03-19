using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TABAS.BackEnd.Models;

namespace TABAS.BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BagCartController : ControllerBase
    {
        private static string jsonFilePath = @".\JSONs\BagCarts.json";

        /// <summary>
        /// This function gets the data of a bag cart.
        /// </summary>
        /// <param name="id"> The bag cart´s identifier </param>
        /// <returns> Returns a bag cart object </returns>
        /// <exception cref="NotSupportedException"></exception>
        [HttpGet("{id}")]
        public object Get(int id)
        {
            BagCartDto[] jsonFromFile = DeserializeJsonFile();

            object response = "";

            foreach (var jsonObject in jsonFromFile)
            {
                if (jsonObject.Id == id)
                {
                    response = jsonObject;
                }
            }

            return response;
        }

        /// <summary>
        /// This function saves the data of a bag cart.
        /// </summary>
        /// <param name="bagCart"> The data of a bag cart </param>
        [HttpPost]
        public void Post(BagCartDto bagCart)
        {
            BagCartDto[] jsonFromFile = DeserializeJsonFile();

            JsonManagement.SerializeJsonFile(bagCart, jsonFromFile, jsonFilePath);
        }

        /// <summary>
        /// This function deserializes a json object.
        /// </summary>
        /// <returns> Returns a json list from a file </returns>
        public static BagCartDto[] DeserializeJsonFile()
        {
            string jsonFromFile = JsonManagement.GetJsonFromFile(jsonFilePath);

            BagCartDto[] jsonObject = JsonConvert.DeserializeObject<BagCartDto[]>(jsonFromFile);

            return jsonObject;
        }
    }
}

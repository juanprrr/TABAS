using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TABAS.BackEnd.Models;

namespace TABAS.BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private static string jsonFilePath = @".\JSONs\Roles.json";

        /// <summary>
        /// This function gets the data of a role.
        /// </summary>
        /// <param name="id"> The name of the role </param>
        /// <returns> Returns a role object </returns>
        /// <exception cref="NotSupportedException"></exception>
        [HttpGet("{name}")]
        public object Get(string name)
        {
            RoleDto[] jsonFromFile = DeserializeJsonFile();

            object response = "";

            foreach (var jsonObject in jsonFromFile)
            {
                if (jsonObject.Name == name)
                {
                    response = jsonObject;
                }
            }

            return response;
        }

        /// <summary>
        /// This function saves the data of a role.
        /// </summary>
        /// <param name="rol"> The data of a role </param>
        [HttpPost]
        public void Post(RoleDto role)
        {
            RoleDto[] jsonFromFile = DeserializeJsonFile();

            JsonManagement.SerializeJsonFile(role, jsonFromFile, jsonFilePath);
        }

        /// <summary>
        /// This function deserializes a json object.
        /// </summary>
        /// <returns> Returns a json list from a file </returns>
        public static RoleDto[] DeserializeJsonFile()
        {
            string jsonFromFile = JsonManagement.GetJsonFromFile(jsonFilePath);

            RoleDto[] jsonObject = JsonConvert.DeserializeObject<RoleDto[]>(jsonFromFile);

            return jsonObject;
        }
    }
}

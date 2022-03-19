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

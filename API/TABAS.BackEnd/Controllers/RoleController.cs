using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TABAS.BackEnd.Models;

namespace TABAS.BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private static string jsonFileName = "Roles.json";

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
            JsonSerialization.SerializeJsonFile(role, jsonFileName);
        }
    }
}

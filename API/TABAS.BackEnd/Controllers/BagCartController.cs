using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TABAS.BackEnd.Models;

namespace TABAS.BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BagCartController : ControllerBase
    {
        private static string jsonFileName = "BagCarts.json";

        /// <summary>
        /// This function gets the data of a bag cart.
        /// </summary>
        /// <param name="id"> The bag cart´s identifier </param>
        /// <returns> Returns a bag cart object </returns>
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
        /// This function saves the data of a bag cart.
        /// </summary>
        /// <param name="bagCart"> The data of a bag cart </param>
        [HttpPost]
        public void Post(BagCartDto bagCart)
        {
            //JsonManagement.SerializeJsonFile(bagCart, jsonFileName);
        }
    }
}

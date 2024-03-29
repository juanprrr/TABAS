﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TABAS.BackEnd.Models;

namespace TABAS.BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuitcaseController : ControllerBase
    {
        private static string jsonFilePath = @".\JSONs\Suitcases.json";

        /// <summary>
        /// This function gets the data of a suitcase.
        /// </summary>
        /// <param name="id"> The suitcase number </param>
        /// <returns> Returns a suitcase object </returns>
        /// <exception cref="NotSupportedException"></exception>
        [HttpGet("{id}")]
        public object Get(int id)
        {
            SuitcaseDto[] jsonFromFile = DeserializeJsonFile();

            object response = "";

            foreach (var jsonObject in jsonFromFile)
            {
                if (jsonObject.Number == id)
                {
                    response = jsonObject;
                }
            }

            return response;
        }

        /// <summary>
        /// This function saves the data of a suitcase.
        /// </summary>
        /// <param name="suitcase"> The data of a suitcase </param>
        [HttpPost]
        public void Post(SuitcaseDto suitcase)
        {
            SuitcaseDto[] jsonFromFile = DeserializeJsonFile();

            JsonManagement.SerializeJsonFile(suitcase, jsonFromFile, jsonFilePath);
        }

        /// <summary>
        /// This function deserializes a json object.
        /// </summary>
        /// <returns> Returns a json list from a file </returns>
        public static SuitcaseDto[] DeserializeJsonFile()
        {
            string jsonFromFile = JsonManagement.GetJsonFromFile(jsonFilePath);

            SuitcaseDto[] jsonObject = JsonConvert.DeserializeObject<SuitcaseDto[]>(jsonFromFile);

            return jsonObject;
        }
    }
}
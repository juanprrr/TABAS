﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TABAS.BackEnd.Models;

namespace TABAS.BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        private static string jsonFilePath = @".\JSONs\Flights.json";

        /// <summary>
        /// This function gets the data of a flight.
        /// </summary>
        /// <param name="id"> The flight number </param>
        /// <returns> Returns a flight object </returns>
        /// <exception cref="NotSupportedException"></exception>
        [HttpGet("{id}")]
        public object Get(int id)
        {
            FlightDto[] jsonFromFile = DeserializeJsonFile();

            object response = "";

            foreach (var jsonObject in jsonFromFile)
            {
                if (jsonObject.Fligth_number == id)
                {
                    response = jsonObject;
                }
            }

            return response;
        }

        /// <summary>
        /// This function saves the data of a flight.
        /// </summary>
        /// <param name="flight"> The data of a flight </param>
        /// <returns></returns>
        [HttpPost]
        public void Post(FlightDto flight)
        {
            FlightDto[] jsonFromFile = DeserializeJsonFile();

            JsonManagement.SerializeJsonFile(flight, jsonFromFile, jsonFilePath);
        }

        /// <summary>
        /// This function deserializes a json object.
        /// </summary>
        /// <returns> Returns a json list from a file </returns>
        public static FlightDto[] DeserializeJsonFile()
        {
            string jsonFromFile = JsonManagement.GetJsonFromFile(jsonFilePath);

            FlightDto[] jsonObject = JsonConvert.DeserializeObject<FlightDto[]>(jsonFromFile);

            return jsonObject;
        }
    }
}

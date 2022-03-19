using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TABAS.BackEnd.Models;
using System.IO;
using System;

namespace TABAS.BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private static string jsonFilePath = @".\JSONs\Employees.json";

        /// <summary>
        /// This function gets the data of an employee.
        /// </summary>
        /// <param name="id"> The emloyee´s identifier </param>
        /// <returns> Returns an employee object </returns>
        /// <exception cref="NotSupportedException"></exception>
        [HttpGet("{id}")]
        public object Get(int id)
        {
            EmployeeDto[] jsonFromFile = DeserializeJsonFile();

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
        /// This function saves the data of an employee.
        /// </summary>
        /// <param name="employee"> The data of an employee </param>
        [HttpPost]
        public void Post(EmployeeDto employee)
        {
            EmployeeDto[] jsonFromFile = DeserializeJsonFile();

            JsonManagement.SerializeJsonFile(employee, jsonFromFile, jsonFilePath);
        }

        /// <summary>
        /// This function deserializes a json object.
        /// </summary>
        /// <returns> Returns a json list from a file </returns>
        public static EmployeeDto[] DeserializeJsonFile()
        {
            string jsonFromFile = JsonManagement.GetJsonFromFile(jsonFilePath);

            EmployeeDto[] jsonObject = JsonConvert.DeserializeObject<EmployeeDto[]>(jsonFromFile);

            return jsonObject;
        }
    }
}

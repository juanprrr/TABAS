using Newtonsoft.Json;
using TABAS.BackEnd.Models;

namespace TABAS.BackEnd
{
    public class JsonManagement
    {
        /// <summary>
        /// This function serializes and indents a json object and also add it to a json file.
        /// </summary>
        /// <param name="jsonObject"> The json object to serialize </param>
        /// <param name="jsonFilePath"> The name of the json file </param>
        public static void SerializeJsonFile(object jsonObject, object[] jsonFromFile, string jsonFilePath)
        {
            List<object> finalJson = new List<object>
            {
                jsonObject
            };

            if (File.Exists(jsonFilePath))
            {
                finalJson.AddRange(jsonFromFile);
            }

            string json = JsonConvert.SerializeObject(finalJson, Formatting.Indented);

            File.WriteAllText(jsonFilePath, json);
        }

        /// <summary>
        /// This function gets the data of a json file into a string.
        /// </summary>
        /// <param name="jsonFilePath"> The file path </param>
        /// <returns> Returns the data of a json file </returns>
        public static string GetJsonFromFile(string jsonFilePath)
        {
            string contactsJsonFromFile = "";

            if (File.Exists(jsonFilePath))
            {
                using (var reader = new StreamReader(jsonFilePath))
                {
                    contactsJsonFromFile = reader.ReadToEnd();
                }
            };

            return contactsJsonFromFile;
        }
    }
}

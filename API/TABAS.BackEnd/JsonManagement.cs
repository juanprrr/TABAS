using Newtonsoft.Json;
using TABAS.BackEnd.Models;

namespace TABAS.BackEnd
{
    public class JsonManagement
    {
        private static string _path = @".\JSONs\";

        /// <summary>
        /// This function serializes and indents a json object and also add it to a json file.
        /// </summary>
        /// <param name="jsonObject"> The json object to serialize </param>
        /// <param name="jsonFileName"> The name of the json file </param>
        public static void SerializeJsonFile(object jsonObject, object[] jsonFromFile, string jsonFileName)
        {
            _path += jsonFileName;

            List<object> finalJson = new List<object>
            {
                jsonObject
            };

            //if (File.Exists(_path))
            //{
            //    finalJson.AddRange(jsonFromFile);
            //}

            string json = JsonConvert.SerializeObject(finalJson, Formatting.Indented);

            File.AppendAllText(_path, json);
        }

        /// <summary>
        /// This function gets the data of a json file into a string.
        /// </summary>
        /// <param name="path"> The file path </param>
        /// <returns> Returns the data of a json file </returns>
        public static string GetJsonFromFile(string path)
        {
            string contactsJsonFromFile = "";

            if (File.Exists(path))
            {
                using (var reader = new StreamReader(path))
                {
                    contactsJsonFromFile = reader.ReadToEnd();
                }
            };

            return contactsJsonFromFile;
        }
    }
}

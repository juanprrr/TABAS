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
        public static void SerializeJsonFile(object jsonObject, string jsonFileName)
        {
            string json = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);

            _path += jsonFileName;

            File.AppendAllText(_path, json);
        }
        /// <summary>
        /// This function deserializes a json object.
        /// </summary>
        /// <param name="jsonFileName"> The name of the json file </param>
        public static void DeserializeJsonFile(string jsonFileName)
        {
            _path += jsonFileName;

            string json = GetJsonFromFile(_path);

            var jsonObject = JsonConvert.DeserializeObject<List<PassengerDto>>(json);
        }

        /// <summary>
        /// This function gets the data of a json file into a string.
        /// </summary>
        /// <param name="path"> The file path </param>
        /// <returns> Returns the data of a json file </returns>
        private static string GetJsonFromFile(string path)
        {
            string contactsJsonFromFile;
            
            using (var reader = new StreamReader(path))
            {
                contactsJsonFromFile = reader.ReadToEnd();
            }

            return contactsJsonFromFile;
        }
    }
}

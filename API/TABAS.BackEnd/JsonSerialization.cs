using Newtonsoft.Json;

namespace TABAS.BackEnd
{
    public class JsonSerialization
    {
        /// <summary>
        /// This function serializes and indents a json object and also add it to a json file.
        /// </summary>
        /// <param name="jsonObject"> The json object to serialize </param>
        /// <param name="jsonFileName"> The name of the json file </param>
        public static void SerializeJsonFile(object jsonObject, string jsonFileName)
        {
            string json = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);

            string _path = @".\JSONs\" + jsonFileName;

            File.AppendAllText(_path, json);
        }
    }
}

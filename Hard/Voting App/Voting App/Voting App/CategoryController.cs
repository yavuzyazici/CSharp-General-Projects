using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting_App
{
    public class CategoryController
    {
        public Dictionary<string, int> categoryVotes = JsonConvert.DeserializeObject<Dictionary<string, int>>(File.ReadAllText(Directory.GetCurrentDirectory() + "\\categoryVotes.json"));

        public void UpdateCategories(Dictionary<string, int> categoryVotess)
        {
            categoryVotes = categoryVotess;

        }
        public void SaveCategories(Dictionary<string, int> keyValuePairs)
        {
            string jsonFilePath = Directory.GetCurrentDirectory() + "\\categoryVotes.json";

            // Serialize the dictionary to JSON
            string jsonContent = JsonConvert.SerializeObject(keyValuePairs, Formatting.Indented);

            // Write JSON content to a file
            File.WriteAllText(jsonFilePath, jsonContent);
        }
        public string LoadCategories()
        {
            string jsonFilePath = Directory.GetCurrentDirectory() + "\\categoryVotes.json";

            string jsonContent = File.ReadAllText(jsonFilePath);

            categoryVotes = JsonConvert.DeserializeObject<Dictionary<string, int>>(jsonContent);

            return jsonContent;
        }

    }
}

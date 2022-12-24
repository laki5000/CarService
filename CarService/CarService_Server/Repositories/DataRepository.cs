using CarService_Common.Models;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace CarService_Server.Repositories
{
    public static class DataRepository
    {
        private const string filename = "alldata.json";

        public static IEnumerable<Data> GetData()
        {
            if (File.Exists(filename))
            {
                var rawData = File.ReadAllText(filename);
                var data = JsonSerializer.Deserialize<IEnumerable<Data>>(rawData);
                return data;
            }

            return new List<Data>();
        }

        public static void StoreData(IEnumerable<Data> data)
        {
            var rawData = JsonSerializer.Serialize(data);
            File.WriteAllText(filename, rawData);
        }
    }
}
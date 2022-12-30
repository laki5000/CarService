using CarService_Common.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CarService_Client.DataProviders
{
    class DataDataProvider
    {
        private const string _url = "http://localhost:5000/api/data";

        public static IEnumerable<Data> GetAllData()
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(_url).Result;

                if( response.IsSuccessStatusCode)
                {
                    var RawData = response.Content.ReadAsStringAsync().Result;
                    var AllData = JsonConvert.DeserializeObject<IEnumerable<Data>>(RawData);
                    return AllData;
                }

                throw new InvalidOperationException(response.StatusCode.ToString());
            }
        }

        public static void CreateData(Data data)
        {
            using (var client = new HttpClient())
            {
                var RawData = JsonConvert.SerializeObject(data);
                var content = new StringContent(RawData, Encoding.UTF8, "application/json");

                var response = client.PostAsync(_url, content).Result;
                if(!response.IsSuccessStatusCode)
                {
                    throw new InvalidOperationException(response.StatusCode.ToString());
                }
            }
        }

        public static void UpdateData(Data data)
        {
            using (var client = new HttpClient())
            {
                var RawData = JsonConvert.SerializeObject(data);
                var content = new StringContent(RawData, Encoding.UTF8, "application/json");
                var response = client.PutAsync(_url, content).Result;

                if (!response.IsSuccessStatusCode)
                {
                    throw new InvalidOperationException(response.StatusCode.ToString());
                }
            }
        }
    }
}

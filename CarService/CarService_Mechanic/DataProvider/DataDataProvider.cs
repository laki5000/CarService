using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using CarService_Common.Models;
using Newtonsoft.Json;

namespace CarService_Mechanic.DataProviders
{
    class DataDataProvider
    {
        private const string _url = "http://localhost:5000/api/data";

        public static IEnumerable<Data> GetData()
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(_url).Result;

                if (response.IsSuccessStatusCode)
                {
                    var rawData = response.Content.ReadAsStringAsync().Result;
                    var datas = JsonConvert.DeserializeObject<IEnumerable<Data>>(rawData);
                    return datas;
                }

                throw new InvalidOperationException(response.StatusCode.ToString());
            }
        }

        public static void CreateData(Data data)
        {
            using (var client = new HttpClient())
            {
                var rawData = JsonConvert.SerializeObject(data);
                var content = new StringContent(rawData, Encoding.UTF8, "application/json");

                var response = client.PostAsync(_url, content).Result;
                if (!response.IsSuccessStatusCode)
                {
                    throw new InvalidOperationException(response.StatusCode.ToString());
                }
            }
        }

        public static void UpdateData(Data data)
        {
            using (var client = new HttpClient())
            {
                var rawData = JsonConvert.SerializeObject(data);
                var content = new StringContent(rawData, Encoding.UTF8, "application/json");

                var response = client.PutAsync(_url, content).Result;
                if (!response.IsSuccessStatusCode)
                {
                    throw new InvalidOperationException(response.StatusCode.ToString());
                }
            }
        }

        public static void DeleteData(long id)
        {
            using (var client = new HttpClient())
            {
                var response = client.DeleteAsync($"{_url}/{id}").Result;
                if (!response.IsSuccessStatusCode)
                {
                    throw new InvalidOperationException(response.StatusCode.ToString());
                }
            }
        }
    }
}
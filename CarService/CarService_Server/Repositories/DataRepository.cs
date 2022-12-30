using CarService_Common.Models;
using Microsoft.VisualBasic;
using System;
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

        public static double CalculateETA(Data data)
        {
            double ETA = 1;
            //vissza adja a mostani időt
            int CarAge = DateAndTime.Now.Year - data.ManufactureYear;

            double[] Severity = { 0.2, 0.2, 0.4, 0.4, 0.6, 0.6, 0.6, 0.8, 0.8, 1 };

            switch (data.WorkCategory)
            {
                case "Chassis":
                    ETA = 3;
                    break;
                case "Engine":
                    ETA = 8;
                    break;
                case "Suspension":
                    ETA = 6;
                    break;
                case "Brake":
                    ETA = 4;
                    break;
            }

            if (CarAge >= 0 && CarAge <= 5)
            {
                ETA *= 0.5;
            }
            if (CarAge >= 10 && CarAge <= 20)
            {
                ETA *= 1.5;
            }
            if (CarAge > 20)
            {
                ETA *= 2;
            }

            ETA *= Severity[data.Seriousness-1];

            return Math.Round(ETA,2);

        }
    }
}
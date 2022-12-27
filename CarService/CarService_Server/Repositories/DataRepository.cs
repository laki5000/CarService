using CarService_Common.Models;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace CarService_Server.Repositories
{
    public static class DataRepository
    {
        public static IEnumerable<Data> GetData()
        {
            using (var database = new DataContext())
            {
                var allData = database.AllData.ToList();

                return allData;
            }
        }

        public static Data GetDataById(long id)
        {

            using (var database = new DataContext())
            {
                var Data = database.AllData.Where(d => d.Id == id).FirstOrDefault();

                return Data;
            }
        }

        public static void AddData(Data data)
        {
            using (var database = new DataContext())
            {
                data.WorkHourEstimation = CalculateETA(data);
                database.AllData.Add(data);
                database.SaveChanges();
            }
        }

        public static void UpdateData(Data data)
        {
            using (var database = new DataContext())
            {
                data.WorkHourEstimation = CalculateETA(data);
                database.AllData.Update(data);
                database.SaveChanges();
            }
        }
        public static void DeleteData(Data data)
        {
            using (var database = new DataContext())
            {
                database.AllData.Remove(data);
                database.SaveChanges();
            }
        }

        public static double CalculateETA(Data data)
        {
            double ETA = 1;
            //vissza adja a mostani időt
            int CarAge = DateAndTime.Now.Year - data.ManufactureYear;

            double[] Severity = { 0.2, 0.2, 0.4, 0.4, 0.6, 0.6, 0.8, 0.8, 1, 1 };

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

            ETA *= Severity[data.Seriousness];

            return ETA;

        }
    }
}
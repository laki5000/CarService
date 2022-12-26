using CarService_Common.Models;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
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
                database.AllData.Add(data);
                database.SaveChanges();
            }
        }

        public static void UpdateData(Data data)
        {
            using (var database = new DataContext())
            {
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
    }
}
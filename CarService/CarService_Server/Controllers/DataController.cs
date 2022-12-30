using CarService_Common.Models;
using CarService_Server.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarService_Server.Controllers
{
    [ApiController]
    [Route("api/data")]
    public class DataController : Controller
    {
        [HttpGet]
        public ActionResult<IEnumerable<Data>> Get()
        {
            var data = DataRepository.GetData();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public ActionResult<Data> Get(int id)
        {
            var datas = DataRepository.GetData();

            var data = datas.FirstOrDefault(x => x.Id == id);
            if (data != null)
            {
                return Ok(data);
            }

            return NotFound();
        }

        [HttpPost]
        public ActionResult Post([FromBody] Data data)
        {
            var datas = DataRepository.GetData().ToList();

            data.WorkHourEstimation = DataRepository.CalculateETA(data);
            data.Id = GetNewId(datas);
            datas.Add(data);

            DataRepository.StoreData(datas);
            return Ok();
        }

        [HttpPut]
        public ActionResult Put([FromBody] Data data)
        {
            var datas = DataRepository.GetData().ToList();

            var dataToUpdate = datas.FirstOrDefault(p => p.Id == data.Id);
            if (dataToUpdate != null)
            {
                dataToUpdate.Name = data.Name;
                dataToUpdate.Type = data.Type;
                dataToUpdate.PlateNumber = data.PlateNumber;
                dataToUpdate.ManufactureYear = data.ManufactureYear;
                dataToUpdate.WorkCategory = data.WorkCategory;
                dataToUpdate.Description = data.Description;
                dataToUpdate.Seriousness = data.Seriousness;
                dataToUpdate.WorkHourEstimation = DataRepository.CalculateETA(data);
                dataToUpdate.Status = data.Status;

                DataRepository.StoreData(datas);
                return Ok();
            }

            return NotFound();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var datas = DataRepository.GetData().ToList();

            var dataToDelete = datas.FirstOrDefault(p => p.Id == id);
            if (dataToDelete != null)
            {
                datas.Remove(dataToDelete);

                DataRepository.StoreData(datas);
                return Ok();
            }

            return NotFound();
        }

        private long GetNewId(IEnumerable<Data> datas)
        {
            long newId = 0;
            foreach (var data in datas)
            {
                if (newId < data.Id)
                {
                    newId = data.Id;
                }
            }

            return newId + 1;
        }
    }
}
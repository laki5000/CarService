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
            var data = DataRepository.GetDataById(id);

            if (data != null)
            {
                return Ok(data);
            }

            return NotFound();
        }

        [HttpPost]
        public ActionResult Post([FromBody] Data data)
        {
            DataRepository.AddData(data);

            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult Put([FromBody] Data data, long id)
        {
            var dbdata = DataRepository.GetDataById(id);

            if (dbdata != null)
            {
                DataRepository.UpdateData(data);
                return Ok();
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(long id)
        {
            var data = DataRepository.GetDataById(id);

            if (data != null)
            {
                DataRepository.DeleteData(data);
                return Ok();
            }

            return NotFound();
        }
    }
}
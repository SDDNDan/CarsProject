using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Infrastructure;
using Service.Services;
using Repository.UnitOfWork;
using Repository;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Service;
using Service.DTO;
using System;
using System.Linq;
using Domain;
using Service.Interfaces;
using Repository.Interfaces;

namespace CarsProject_DotNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ICarService _carService;
       
        public ValuesController(ICarService carService)
        {
            _carService = carService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<CarDTO>> Get()
        {
            //EngineDTO engineDTO = new EngineDTO {
            //Description = "TW100",
            //CylindersNumber = 3
            //};
            //engineService.InsertEngine(engineDTO);

            //var x = engineService.GetEngine(Guid.Parse("22268589-F27B-4D35-96C8-6B48218A10C9"));
            //return new string[] { x.Description.ToString() };
            IEnumerable<CarDTO> cars = _carService.GetCars() as IEnumerable<CarDTO>;         
            return cars.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Car> Get(int id)
        {
             return _carService.GetCar22(Guid.Parse("A7B1A155-B460-4582-B84E-F468965531F2"));
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

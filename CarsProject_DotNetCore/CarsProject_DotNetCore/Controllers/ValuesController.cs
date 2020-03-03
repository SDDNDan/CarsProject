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

namespace CarsProject_DotNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<CarDTO>> Get()
        {
            var optionsBuilder = new DbContextOptionsBuilder<AplicationContext>();
            AplicationContext context = new AplicationContext(optionsBuilder.Options);
            UnitOfWork unitOfWork = new UnitOfWork(context);
            var mappingConfig = new MapperConfiguration(mc =>               // Auto Mapper Configurations
            {
                mc.AddProfile(new MappingProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            CarService carService = new CarService( unitOfWork, mapper);

            //EngineDTO engineDTO = new EngineDTO {
            //Description = "TW100",
            //CylindersNumber = 3
            //};
            //engineService.InsertEngine(engineDTO);
            IEnumerable<CarDTO> cars = carService.GetCars();

            //var x = engineService.GetEngine(Guid.Parse("22268589-F27B-4D35-96C8-6B48218A10C9"));
            //return new string[] { x.Description.ToString() };
            return cars.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Car> Get(int id)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AplicationContext>();
            AplicationContext context = new AplicationContext(optionsBuilder.Options);
            UnitOfWork unitOfWork = new UnitOfWork(context);
            var mappingConfig = new MapperConfiguration(mc =>               // Auto Mapper Configurations
            {
                mc.AddProfile(new MappingProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            CarService carService = new CarService(unitOfWork, mapper);
            // return carService.GetCar(Guid.Parse("A7B1A155-B460-4582-B84E-F468965531F2"));
            return carService.GetCar22(Guid.Parse("A7B1A155-B460-4582-B84E-F468965531F2"));
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

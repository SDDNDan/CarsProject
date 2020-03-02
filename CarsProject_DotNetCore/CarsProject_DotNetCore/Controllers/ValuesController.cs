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

namespace CarsProject_DotNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            /*var optionsBuilder = new DbContextOptionsBuilder<AplicationContext>();
            AplicationContext context = new AplicationContext(optionsBuilder.Options);
            UnitOfWork unitOfWork = new UnitOfWork(context);
            var mappingConfig = new MapperConfiguration(mc =>               // Auto Mapper Configurations
            {
                mc.AddProfile(new MappingProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            EngineService engineService = new EngineService(context, unitOfWork, mapper);
            */
            //EngineDTO engineDTO = new EngineDTO {
            //Description = "TW100",
            //CylindersNumber = 3
            //};
            //engineService.InsertEngine(engineDTO);

            //var x = engineService.GetEngine(Guid.Parse("22268589-F27B-4D35-96C8-6B48218A10C9"));
            //return new string[] { x.Description.ToString() };
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
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

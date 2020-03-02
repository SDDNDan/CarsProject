﻿using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using Service;

namespace Infrastructure
{
    public class ServicesInfrastructure
    {
        private IServiceCollection _services;

        public ServicesInfrastructure(IServiceCollection services)
        {
            _services = services;
        }
        public void AddDbContext()
        {
            _services.AddDbContext<AplicationContext>();
        }
        public void ConfigureMapper()
        {
            var mappingConfig = new MapperConfiguration(mc =>               // Auto Mapper Configurations
            {
                mc.AddProfile(new MappingProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            _services.AddSingleton(mapper);
        }
        
    }

}
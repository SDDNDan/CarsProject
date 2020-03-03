using Autofac;
using Autofac.Extensions.DependencyInjection;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using Repository.Interfaces;
using Repository.UnitOfWork;
using Service;
using Service.Interfaces;
using Service.Services;
using System;

namespace Infrastructure
{
    public class ServicesInfrastructure
    {
        private IServiceCollection _services;
        private Autofac.ContainerBuilder _builder;
        private Autofac.IContainer _container;
        private IMapper _mapper;


        public ServicesInfrastructure(IServiceCollection services)
        {
            _services = services;
            _builder = new Autofac.ContainerBuilder();
        }
        public void ConfigureServices()
        {
            _services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            _services.AddDbContext<AplicationContext>();

            var mappingConfig = new MapperConfiguration(mc =>               // Auto Mapper Configurations
            {
                mc.AddProfile(new MappingProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            _mapper = mapper;
            _services.AddSingleton(mapper);
        }

        private void RegisterBuilder()
        {
            _builder.Populate(_services);

            _builder.Register((c,p)=> new DbContextOptions<AplicationContext>());
            _builder.RegisterType<AplicationContext>();
            _builder.Register((c,p) => 
                 new UnitOfWork(c.Resolve<AplicationContext>()))
                 .As<IUnitOfWork>();

            _builder.Register((c, p) =>
                new CarService(c.Resolve<IUnitOfWork>(), _mapper))
                .As<ICarService>();
          
        }
        public void CreateContainer()
        {
            RegisterBuilder();
            _container = _builder.Build();
        }

        public IServiceProvider GetServiceProvider()
        {
            return _container.Resolve<IServiceProvider>();
        }
        public Autofac.IContainer GetContainer()
        {
            return _container;
        }
    }

}

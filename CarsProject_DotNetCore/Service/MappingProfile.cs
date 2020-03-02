﻿using AutoMapper;
using Domain;
using Service.DTO;


namespace Service
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Car, CarDTO>()
                .ForMember(dest => dest.Brand,
                           opt => opt.MapFrom(src=>src.Brand));
                // need to map the objects.
            CreateMap<CarDTO, Car>();

            CreateMap<Engine, EngineDTO>();
            CreateMap<EngineDTO, Engine>();

            CreateMap<Chassis, ChassisDTO>();
            CreateMap<ChassisDTO, Chassis>();
        }
    }
}

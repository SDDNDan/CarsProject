﻿using AutoMapper;
using Domain;
using Service.DTO;


namespace Service
{
    public class MappingProfile : Profile
    {
    // This one should be in infrastructure
        public MappingProfile()
        {
            CreateMap<Car, CarDTO>()
                //.IncludeMembers(s => s.Chassis, s => s.Engine)
                .ForMember(dest => dest.Chassis,
                           opt => opt.MapFrom(src => src.Chassis))
                .ForPath(dest => dest.Chassis.CodeNumber,
                            opt => opt.MapFrom(src => src.Chassis.CodeNumber))
                .ForPath(dest => dest.Chassis.Description,
                            opt => opt.MapFrom(src => src.Chassis.Description))
                .ForPath(dest => dest.Engine.CylindersNumber,
                            opt => opt.MapFrom(src => src.Engine.CylindersNumber))
                .ForPath(dest => dest.Engine.Description,
                            opt => opt.MapFrom(src => src.Engine.Description));
            //CreateMap<Chassis, CarDTO>();
            //CreateMap<Engine, CarDTO>();
            
            CreateMap<CarDTO, Car>();

            CreateMap<Engine, EngineDTO>();
            CreateMap<EngineDTO, Engine>();

            CreateMap<Chassis, ChassisDTO>();
            CreateMap<ChassisDTO, Chassis>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Service.DTO
{
    public class CarDTO
    {
        public string Brand { get; set; }
        public ChassisDTO Chassis { get; set; }
        public EngineDTO Engine { get; set; }
    }
}

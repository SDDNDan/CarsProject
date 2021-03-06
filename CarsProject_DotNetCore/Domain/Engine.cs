﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Domain
{
    public class Engine
    {
        public Engine()
        {
            Cars = new HashSet<Car>();
        }

        [Required] [Key]
        public Guid EngineId { get; set; }
        public string Description { get; set; }
        public int CylindersNumber { get; set; }
        [ForeignKey("EngineId")]
        [InverseProperty("Engine")]
        public ICollection<Car> Cars { get; set; }
    }
}
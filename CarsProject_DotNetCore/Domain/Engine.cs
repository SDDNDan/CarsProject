using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Domain
{
    public class Engine
    {
        [Required] [Key]
        public Guid EngineId { get; set; }
        public string Description { get; set; }
        public int CylindersNumber { get; set; }
        [ForeignKey("EngineId")]
        public ICollection<Car> Cars { get; set; }
    }
}
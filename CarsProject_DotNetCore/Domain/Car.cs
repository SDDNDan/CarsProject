using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Car
    {
        public Car()
        {
        }
        [Required] [Key]
        public Guid CarId { get; set; }
        [Required]
        public Guid ChassisId { get; set; }
        [ForeignKey("ChassisId")]
        public Chassis Chassis { get; set; }
        public string Brand { get; set; }
        [Required]
        public Guid EngineId { get; set; }
        [ForeignKey("EngineId")]
        public Engine Engine { get; set; }
        public virtual ICollection<CarUser> CarUsers { get; set; }

    }
}
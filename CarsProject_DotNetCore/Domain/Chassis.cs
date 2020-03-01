using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Domain
{
    public class Chassis
    {
        public Chassis()
        {
            Cars = new HashSet<Car>();
        }
        [Required] [Key]
        public Guid ChassisId { get; set; }
        public string Description { get; set; }
        public string CodeNumber { get; set; }
        [ForeignKey("ChassisIdF")]
        public virtual ICollection<Car> Cars { get; set; }
    }
}
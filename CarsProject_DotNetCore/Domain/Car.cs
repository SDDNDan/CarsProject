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
            //Users = new HashSet<User>();
        }
        [Required] [Key]
        public Guid CarId { get; set; }
        [Required]
        public Guid ChassisIdF { get; set; }
        public string Brand { get; set; }
        [Required]
        public Guid EngineIdF { get; set; }
        //[ForeignKey("CarId")]
        //[InverseProperty("Cars")]
        public virtual ICollection<CarUser> CarUsers { get; set; }

    }
}
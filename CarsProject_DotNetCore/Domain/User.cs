using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class User
    {
        public User()
        {
           // Cars = new HashSet<Car>();
        }
        [Required] [Key]
        public Guid UserId { get; set; }
        //[ForeignKey("UserId")]
        //[InverseProperty("Users")]
        public virtual ICollection<CarUser> CarsUsers { get; set; }
             
    }
}
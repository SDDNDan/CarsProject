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
        }
        [Required] [Key]
        public Guid UserId { get; set; }

        public virtual ICollection<CarUser> CarsUsers { get; set; }
             
    }
}
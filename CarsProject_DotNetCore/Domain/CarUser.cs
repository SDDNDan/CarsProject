using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    public class CarUser
    {
        [Required] 
        public Guid CarId { get; set; }
        [ForeignKey("CarId")]
        public Car Car { get; set; }
        [Required] 
        public Guid UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}

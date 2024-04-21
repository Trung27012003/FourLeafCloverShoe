using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourLeafCloverShoe.Share.Models
{
    public class Address
    {
        public Guid Id { get; set; }
        public string? UserId { get; set; }
        
        public string? RecipientName { get; set; }
        public string? RecipientPhone { get; set; }
        public string? City { get; set; }
        public string? Province { get; set; }
        public string? Wards { get; set; }
        public string? Description { get; set; }
        public bool? IsDefault { get; set; }
        [ForeignKey("UserId")]
        public virtual User? Users { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourLeafCloverShoe.Share.Models
{
    public class Rate
    {
        public Guid Id { get; set; }
        public Guid OrderItemId { get; set; }
        public string? Contents { get; set; }
        public string? Reply { get; set; }
        public string? ImageUrl { get; set; }
        public float? Rating { get; set; }
        public int? Status { get; set; }
        [ForeignKey("OrderItemId")]
        public virtual OrderItem? OrderItems { get; set; }
    }
}

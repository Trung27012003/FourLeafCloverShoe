using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourLeafCloverShoe.Share.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public string? UserId { get; set; }
        public string StaffId { get; set; } // id nhan vien
        public Guid? VoucherId { get; set; }
        public string? OrderCode { get; set; }
        public string? PaymentType { get; set; }
        public int? OrderStatus { get; set; }
        public string? RecipientName { get; set; }
        public string? RecipientAddress { get; set; }// địa chỉ
        public string? RecipientPhone { get; set; }// sdt
        public decimal? TotalAmout { get; set; } // tổng tiền trước khi áp dụng
        public decimal? VoucherValue { get; set; } // giá trị voucher
        public decimal? ShippingFee { get; set; } // phí ship
        public DateTime? CreateDate { get; set; } // ngày tạo bill
        public DateTime? UpdateDate { get; set; } // ngày update bill
        public DateTime? ShipDate { get; set; } // ngày Ship
        public DateTime? PaymentDate { get; set; } // ngày thanh toán
        public DateTime? DeliveryDate { get; set; } // ngày nhận hàng
        public string? Description { get; set; } // mo ta
        [ForeignKey("UserId")]
        public virtual User? Users { get; set; }
        [ForeignKey("StaffId")]
        [NotMapped]
        public virtual User? Staff { get; set; }
        [ForeignKey("VoucherId")]

        public virtual Voucher? Vouchers { get; set; }

        public virtual List<OrderItem>? OrderItems { get; set; }
    }
}

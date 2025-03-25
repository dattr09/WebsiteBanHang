using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace WebsiteBanHang.Models
{
    public class Order
    {
        public int Id { get; set; }
        public required string UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public required string ShippingAddress { get; set; }
        public required string Notes { get; set; }
        [ForeignKey("UserId")]
        [ValidateNever]
        public required ApplicationUser ApplicationUser { get; set; }
        public required List<OrderDetail> OrderDetails { get; set; }
    }
}
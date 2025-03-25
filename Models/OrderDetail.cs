using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebsiteBanHang.Models
{
    public class OrderDetail
    {
   [Key]
    public int Id { get; set; }

    [ForeignKey("Order")]
    public int OrderId { get; set; }

    [ForeignKey("Product")]
    public int ProductId { get; set; }

    public int Quantity { get; set; }
    public decimal Price { get; set; }

    public Order Order { get; set; } = null!;  // Dùng null! để tránh lỗi required
    public Product? Product { get; set; } // Cho phép Product có thể null
    }
}
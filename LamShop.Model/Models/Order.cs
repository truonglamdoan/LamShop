using LamShop.Model.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamShop.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [MaxLength(256)]
        public string CustomerName { get; set; }
        [MaxLength(256)]
        public string CustomerAddress { get; set; }
        [MaxLength(256)]
        public string CustomerPhone { get; set; }
        [MaxLength(256)]
        public string CustomerMessage { get; set; }
        public DateTime? CreatedDay { get; set; }
        public string CreatedBy { get; set; }
        [Required]
        public string PaymentMethod { get; set; }
        [Required]
        public string PaymentStatus { get; set; }
        public bool Status { get; set; }

        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }

    }
}

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
    public class Order : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerMessage { get; set; }
        [Required]
        public string PaymentMethod { get; set; }
        [Required]
        public string PaymentStatus { get; set; }

        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }

    }
}

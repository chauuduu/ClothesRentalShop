using Domain.Cloth;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Invoices
{
    [Table("DetailInvoice")]
    public class DetailInvoice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int ID { get; set; }
        public int? IDInvoice { get; set; }
        public int? IDClothes { get; set; }
        public int? Quantity { get; set; }

        public Invoice Invoice { get; set; }
        public Clothes Cloth { get; set; }
    }
}

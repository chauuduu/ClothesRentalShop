using Domain.Cloth;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.LaundryInvoices
{
    [Table("DetailInvoiceLaundry")]
    public class DetailInvoiceLaundry
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int ID { get; set; }
        public int? IDLaundryInvoice { get; set; }
        public int? IDClothes { get; set; }
        public int? Price { get; set; }
        public int? Quantity { get; set; }

        public LaundryInvoice LaundryInvoice { get; set; }
        public Clothes Cloth { get; set; }
    }
}


using Domain.Staffs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Laundries;

namespace Domain.LaundryInvoices
{
    [Table("LaundryInvoice")]
    public class LaundryInvoice
    {
        public LaundryInvoice()
        {
            this.DetailInvoiceLaundries = new List<DetailInvoiceLaundry>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int ID { get; set; }
        public DateTime? Date { get; set; }
        public int? IDLaundry { get; set; }
        public int? IDStaff { get; set; }
        public int? Total { get; set; }

        public Laundry Laundry { get; set; }
        public Staff Staff { get; set; }
        public List<DetailInvoiceLaundry> DetailInvoiceLaundries { get; set; }
    }
}


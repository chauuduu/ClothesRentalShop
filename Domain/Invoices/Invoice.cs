using Domain.Customers;
using Domain.Staffs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Invoices
{
    [Table("Invoice")]
    public class Invoice
    {
        public Invoice()
        {
            this.DetailInvoices = new List<DetailInvoice>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int ID { get; set; }
        public DateTime? Date { get; set; }
        public int? IDCustomer { get; set; }
        public int? IDStaff { get; set; }
        public int? Discount { get; set; }
        public int? Total { get; set; }

        public Customer Customer { get; set; }
        public Staff Staff { get; set; }
        public List<DetailInvoice> DetailInvoices { get; set; }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Invoices;

namespace Domain.Customers
{
    [Table("Customer")]
    public class Customer
    {
        public Customer()
        {
            this.Invoices = new List<Invoice>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int ID { get; set; }
        [MaxLength(100)]
        public string FullName { get; set; }
        [MaxLength(50)]
        public string Phone { get; set; }
        [MaxLength(50)]
        public string Address { get; set; }

        public List<Invoice> Invoices { get; set; }
    }
}


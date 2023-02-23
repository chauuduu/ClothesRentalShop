using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Invoices;
using Domain.LaundryInvoices;

namespace Domain.Staffs
{
    [Table("Staff")]
    public class Staff
    {
        public Staff()
        {
            this.Invoices = new List<Invoice>();
            this.LaundryInvoices = new List<LaundryInvoice>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int ID { get; set; }
        [MaxLength(50)]
        public string CCCD { get; set; }
        [MaxLength(50)]
        public string FullName { get; set; }
        [MaxLength(50)]
        public string Birthday { get; set; }
        [MaxLength(50)]
        public string Phone { get; set; }
        [MaxLength(50)]
        public string Address { get; set; }
        public int? IDRole { get; set; }

        public RoleStaff RoleStaff { get; set; }
        public List<Invoice> Invoices { get; set; }
        public List<LaundryInvoice> LaundryInvoices { get; set; }
    }
}

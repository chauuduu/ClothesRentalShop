using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Cloth
{
    [Table("Origin")]
    public class Origin
    {
        public Origin()
        {
            this.Clothes = new List<Clothes>();
        }

        [Key]
        [Required]
        public int IDOrigin { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Address { get; set; }

        public List<Clothes> Clothes { get; set; }
    }
}

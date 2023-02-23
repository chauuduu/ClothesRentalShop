using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Cloth
{
    [Table("TypeClothes")]
    public class TypeClothes
    {
        public TypeClothes()
        {
            this.Clothes = new List<Clothes>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int IDType { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public int? Limit { get; set; }

        public List<Clothes> Clothes { get; set; }
    }
}

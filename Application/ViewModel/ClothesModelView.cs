using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModel
{
    public class ClothesModelView
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Size { get; set; }
        public int? Price { get; set; }
        public int? RentalTime { get; set; }
        public int? RentalPrice { get; set; }
        public bool? IsRental { get; set; }
        public int? IDType { get; set; }
        public int? IDOrigin { get; set; }
    }
}

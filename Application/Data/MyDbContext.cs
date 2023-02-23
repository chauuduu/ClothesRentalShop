using Application.ViewModel;
using Domain.Cloth;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Data
{
    public class MyDbContext : DbContext
    {

        public virtual DbSet<Clothes> Clothes { get; set; }
        private const string connectionString = @"Server=DESKTOP-FF1278R;Database=ClothesShop;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=False";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);
        }

    }
}

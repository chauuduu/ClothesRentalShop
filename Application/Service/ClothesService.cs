using Application.Data;
using Application.ViewModel;
using Domain.Cloth;
using Infrastructure.Interface;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public class ClothesService : IClothesService
    {
        public string Add(Clothes Clothe)
        {
            using (var db = new MyDbContext())
            {
                db.Add(Clothe);
                db.SaveChanges();
                return "Insert Success";
            }
        }

        public string Delete(int ID)
        {
            using (var db = new MyDbContext())
            {
                var Clothe = db.Clothes.Where(e => e.ID == ID).FirstOrDefault();
                if (Clothe == null) return "Delete failed";
                db.Clothes.Remove(Clothe);
                db.SaveChanges();
                return "Delete Success";
            }
        }

        public List<Clothes> GetList()
        {
            using (var db = new MyDbContext())
            {
                var rs = db.Clothes.ToList<Clothes>();
                return rs;
            }
        }

        public List<Clothes> GetListLike(string Name)
        {
            using (var db = new MyDbContext())
            {
                var rs = db.Clothes.Where(e => e.Name.Contains(Name)).ToList<Clothes>();
                return rs;
            }
        }

    }
}

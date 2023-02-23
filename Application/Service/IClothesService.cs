using Application.ViewModel;
using Domain.Cloth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public interface IClothesService
    {
        List<Clothes> GetList();
        List<Clothes> GetListLike(String Name);
        String Add(Clothes Clothe);
        String Delete(int ID);
    }
}

using Application.Service;
using Domain.Cloth;
using Microsoft.AspNetCore.Mvc;

namespace ClothesRentalShop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClothesController : ControllerBase
    {
        readonly IClothesService ClothesService;
        public ClothesController(IClothesService ClothesService)
        {
            this.ClothesService = ClothesService;
        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(ClothesService.GetList());
        }
        [HttpGet("Name")]
        public IActionResult GetLike(String Name)
        {
            return Ok(ClothesService.GetListLike(Name));
        }
        [HttpPost]
        public async Task<IActionResult> Insert(Clothes ClothesEx)
        {
            return Ok(ClothesService.Add(ClothesEx));
        }
        [HttpDelete("ID")]
        public IActionResult Delete(int ID)
        {
            return Ok(ClothesService.Delete(ID));
        }
    }
}


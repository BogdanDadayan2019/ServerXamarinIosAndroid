using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FinaleWeb2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<ClothesType> Get()
        {
            using ApplicationContext db = new ApplicationContext();

            var s1 = db.ClothesType.ToList();

            return s1.ToList();
        }

        [HttpPost]
        public string Post([FromBody] Clothes value)
        {
            using ApplicationContext db = new ApplicationContext();

            value.Id = 0;
            db.Clothes.Add(value);
            db.SaveChanges();

            return value.NameClothes;
        }

        [Route("deleteclothes")]
        public string Post1([FromBody] Clothes value)
        {
            using ApplicationContext db = new ApplicationContext();

            var itemForDelete = db.Clothes.FirstOrDefault(item => item.NameClothes == value.NameClothes);
            db.Clothes.Remove(itemForDelete);
            db.SaveChanges();

            return value.NameClothes;
        }

        [Route("changeclothes")]
        public string Post2([FromBody] Clothes value)
        {
            using ApplicationContext db = new ApplicationContext();

            var itemForChange = db.Clothes.FirstOrDefault(item => item.Id == value.Id);
            itemForChange.NameClothes = value.NameClothes;
            db.SaveChanges();

            return value.NameClothes;
        }


        [Route("allclothes")]
        public IEnumerable<Clothes> GetAllClothes()
        {
            using ApplicationContext db = new ApplicationContext();
            
            var s2 = db.Clothes.ToList();
            var cllist = s2;

            return cllist;
        }

        [Route("tshirt")]
        public IEnumerable<Clothes> GetClothesTshirt()
        {
            using ApplicationContext db = new ApplicationContext();

            var s1 = db.ClothesType.ToList();
            var s2 = db.Clothes.ToList();   
            var cllist = s2.Where(c => c.IdType == 7);

            return cllist;
        }

        [Route("hoodie")]
        public IEnumerable<Clothes> GetClothesHoodie()
        {
            using ApplicationContext db = new ApplicationContext();

            var s1 = db.ClothesType.ToList();
            var s2 = db.Clothes.ToList();
            var cllist = s2.Where(c => c.IdType == 8);

            return cllist;
        }

        [Route("cap")]
        public IEnumerable<Clothes> GetClothesCap()
        {
            using ApplicationContext db = new ApplicationContext();

            var s1 = db.ClothesType.ToList();
            var s2 = db.Clothes.ToList();
            var cllist = s2.Where(c => c.IdType == 9);

            return cllist;
        }

        [Route("socs")]
        public IEnumerable<Clothes> GetClothesSocs()
        {
            using ApplicationContext db = new ApplicationContext();

            var s1 = db.ClothesType.ToList();
            var s2 = db.Clothes.ToList();
            var cllist = s2.Where(c => c.IdType == 10);

            return cllist;
        }

    }
}

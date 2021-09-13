using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinaleWeb2
{
    [Controller]
    public class Clothes
    {

        [Key]
        public int Id { get; set; }

        public int IdType { get; set; }

        public string NameClothes { get; set; }

    }
}

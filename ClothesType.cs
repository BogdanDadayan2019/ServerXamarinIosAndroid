using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinaleWeb2
{
    public class ClothesType
    {

        [Key]
        public int Id { get; set; }

        public string NameType { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL1_products_.Model
{
   public class Products
    {
        public int ProductId { get; set; }
        public string PName { get; set; }
        public float Price { get; set; }
        public string ProductUrl { get; set; }
        public string Description { get; set; }
        public int BrandId { get; set; }

    }
}

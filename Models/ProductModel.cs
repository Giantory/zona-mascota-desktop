using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ProductModel
    {
        int id { get; set; }
        string description { get; set; }
        int category { get; set; }
        double purchasePrice { get; set; }
        double salePrice { get; set; }

    }
}

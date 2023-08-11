using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFullStack.Product.Entities
{
    public class Product
    {
        public int Id  { get; set; }
        public string? ProductName { get; set; }
        public int Stock { get; set; }
        public string? userFullName { get; set; }
    }
}

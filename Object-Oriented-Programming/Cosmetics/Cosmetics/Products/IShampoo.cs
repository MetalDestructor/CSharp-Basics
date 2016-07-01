using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products
{
    public interface IShampoo : IProduct
    {
        int Quantity { get; set; }
        UsageType Usage { get; set; }
    }
}

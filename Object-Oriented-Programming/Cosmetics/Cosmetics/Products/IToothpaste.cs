namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IToothpaste:IProduct
    {
        string Ingredients { get; set; }
    }
}

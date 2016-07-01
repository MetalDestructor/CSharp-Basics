namespace Cosmetics.Products
{
    using System;
    public interface IProduct
    {
        string Name { get; set; }
        string Brand { get; set; }
        decimal Price { get; set; }
        GenderType Gender { get; set; }
    }
}

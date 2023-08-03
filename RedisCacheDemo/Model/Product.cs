using System.Collections.Generic;

namespace RedisCacheDemo.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int Stock { get; set; }
        public IList<ProductImage> productImages { get; set; }
    }
}

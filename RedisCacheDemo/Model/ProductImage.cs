using System.ComponentModel.DataAnnotations.Schema;

namespace RedisCacheDemo.Model
{
    public class ProductImage
    {
        public int Id { get; set; }
        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product Products { get; set; }
        public string path { get; set; }
    }
}

namespace EcommerceWebapp.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string? PoductName { get; set; }

        public string? ProductDescription { get; set; }

        public string? ProductImage { get; set; }

        public int? CatId { get; set; }

        public decimal? Price { get; set; }

        public decimal? Discount { get; set; }
    }
}

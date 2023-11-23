namespace EcommerceWebapp.Models
{
    public class OrderViewModel
    {
        public int Id { get; set; }

        public string? OrderNo { get; set; }

        public string? UserId { get; set; }

        public int? ProductId { get; set; }

        public int? Quantity { get; set; }
    }
}

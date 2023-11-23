namespace EcommerceAPI.ViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }

        public string? OrderNo { get; set; }

        public string? UserId { get; set; }

        public string? ProductName { get; set; }

        public int? Quantity { get; set; }
    }
}

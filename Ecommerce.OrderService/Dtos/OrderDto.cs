namespace Ecommerce.OrderService.Dtos
{
    public class OrderDto
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public int ProductId { get; set; }
        public int OrderQuantity { get; set; }
    }
}

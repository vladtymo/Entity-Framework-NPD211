namespace ef_npd211.Data.Entities
{
    // entities
    public class Product
    {
        // Primary Key: Id/ID/id ProductId
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int? Quantity { get; set; }
        public int CategoryId { get; set; }
        public int Discount { get; set; }

        // navigation properties
        public Category Category { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}

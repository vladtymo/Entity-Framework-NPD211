namespace ef_npd211.Data.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}

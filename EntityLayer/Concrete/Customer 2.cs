namespace EntityLayer.Concrete
{
    public class Customer
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string City { get; set; }
    }
}
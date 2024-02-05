namespace EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; }
        public required string CategoryName { get; set; }
        public required string Stock { get; set; }
    }
}
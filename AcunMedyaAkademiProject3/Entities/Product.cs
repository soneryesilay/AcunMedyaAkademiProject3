namespace AcunMedyaAkademiProject3.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public int ProductName { get; set; }
        public int ProducDescription { get; set; }
        public int ProducImageUrl { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}

namespace AcunMedyaAkademiProject3.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<Product> Product { get; set; }
    }
}

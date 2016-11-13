
namespace Ivedix.miTranslator.Model
{
    public class Key
    {
        public int KeyID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }

    }
}

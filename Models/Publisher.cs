namespace Catalina_Frunza_Laborator2.Models
{
    public class Publisher
    {
        public int ID { get; set; }
        public string PublisherName { get; set; }
        public ICollection<Books>? Books { get; set; } //navigation property
    }
}

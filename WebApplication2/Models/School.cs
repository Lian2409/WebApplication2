namespace WebApplication2.Models
{
    public class School
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public string Phone { get; set; }

        public ICollection<Students> Students { get; set; } = new List<Students>();
    }
}
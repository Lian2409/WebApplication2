namespace WebApplication2.Models
{
    public class Students
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int GradeLevel1 { get; set; }

        public int? SchoolId { get; set; }

        public School? School { get; set; }
    }
}

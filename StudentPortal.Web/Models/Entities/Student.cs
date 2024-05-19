namespace StudentPortal.Web.Models.Entities
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public bool Subscribed { get; set; }
    }
}

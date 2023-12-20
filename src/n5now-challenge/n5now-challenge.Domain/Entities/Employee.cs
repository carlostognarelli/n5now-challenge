namespace n5now_challenge.Domain.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateOnly? Birthdate { get; set; }
        public bool? IsActive { get; set; }
        public virtual ICollection<Permission> Permissions { get; set; } = new List<Permission>();
    }
}

namespace FirstBlazorApp.Models
{
    internal class Employee : Entity
    {
        public string Position { get; set; }

        public DateTime StartDate { get; set; }

        public Employee(int id, string name, string position, DateTime? startDate = null) : base(id, name)
        {
            Id = id;
            Name = name;
            Position = position;
            StartDate = startDate.HasValue ? startDate.Value : DateTime.Today;
        }
    }
}

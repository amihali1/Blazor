namespace BlazorEmployeeEF.Data
{
    public class Employee : Entity
    {
        public DateTime StartDate { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public string Company { get; set; }
    }
}

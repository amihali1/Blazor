namespace BlazorEmployeeEF.Data
{
    // Employee entity with employer specific data
    public class Employee : Entity
    {
        public DateTime StartDate { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public string Company { get; set; }
    }
}

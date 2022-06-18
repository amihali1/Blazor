namespace BlazorEmployeeEF.Data
{
    // Base class for all entities
    public class Entity : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

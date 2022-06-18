namespace BlazorEmployeeEF.Data
{
    // Interface with common properties for all entities
    public interface IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

using FirstBlazorApp.Interfaces;

namespace FirstBlazorApp.Models
{
    public class Entity : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Entity(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}

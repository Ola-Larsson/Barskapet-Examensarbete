namespace Server.Models
{
    public class Tag : BaseEntity
    {
        public string Name { get; set; }
        public Guid DrinkId { get; set; }
    }
}
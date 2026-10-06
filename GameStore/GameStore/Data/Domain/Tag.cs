using System.ComponentModel.DataAnnotations;

namespace GameStore.Data.Domain
{
    public class Tag
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        public virtual ICollection<GameTag> GameTags { get; set; } = new List<GameTag>();
    }
}
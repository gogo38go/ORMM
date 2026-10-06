using System.ComponentModel.DataAnnotations;

namespace GameStore.Data.Domain
{
    public class Genre
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        public virtual ICollection<Game> Games { get; set; } = new List<Game>();
    }
}

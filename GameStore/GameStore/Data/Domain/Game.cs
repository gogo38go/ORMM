using System.ComponentModel.DataAnnotations;

namespace GameStore.Data.Domain
{
    public class Game
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        public decimal Price { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public int DeveloperId { get; set; }
        public virtual Developer Developer { get; set; } = null!;

        [Required]
        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; } = null!;

        public virtual ICollection<GameTag> GameTags { get; set; } = new List<GameTag>();
        public virtual ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();
    }

}

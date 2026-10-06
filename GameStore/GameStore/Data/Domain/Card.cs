using System.ComponentModel.DataAnnotations;

namespace GameStore.Data.Domain
{
    public class Card
    {
        public int Id { get; set; }

        [Required]
        public string Number { get; set; } = null!;

        public string? Cvc { get; set; }

        public string? Type { get; set; }

        [Required]
        public int UserId { get; set; }
        public virtual User User { get; set; } = null!;

        public virtual ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();
    }
}

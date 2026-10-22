using System.ComponentModel.DataAnnotations;

namespace GermanLearningCompanion.Models
{
    public class VocabularyWord
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string German { get; set; } = string.Empty;

        [StringLength(10)]
        public string Article { get; set; } = string.Empty;

        [StringLength(100)]
        public string Plural { get; set; } = string.Empty;

        [Required]
        [StringLength(200)]
        public string English { get; set; } = string.Empty;

        [StringLength(200)]
        public string Bengali { get; set; } = string.Empty;

        public string Example { get; set; } = string.Empty;

        [StringLength(10)]
        public string Level { get; set; } = "A1";

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? NextReviewAt { get; set; }
    }
}

using GermanLearningCompanion.Models;
using Microsoft.EntityFrameworkCore;

namespace GermanLearningCompanion.Data
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<VocabularyWord> VocabularyWords { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;

namespace TradeJournalAPI.Models
{
    public class TradeJournalDbContext : DbContext
    {
        public TradeJournalDbContext(DbContextOptions<TradeJournalDbContext> options)
            : base(options)
        {
        }

        public DbSet<TradeJournal> TradeJournals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TradeJournal>().ToTable("tbl_tradeJournal");
        }
    }
}
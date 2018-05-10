
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace AtomJournal.Models
{
    public class JournalContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public JournalContext(DbContextOptions<JournalContext> options) : base(options) { }
        public DbSet<User> Users { get;set; }
        public DbSet<Journal> Journals { get;set; }
        public DbSet<Comment> Comments {get;set;}
    }
}
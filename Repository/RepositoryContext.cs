using Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Configuration;

namespace Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new QuestionConfiguration());
            modelBuilder.ApplyConfiguration(new AnswerConfiguration());
        }
        public DbSet<User>? Users { get; set; }
        public DbSet<Answer>? Answers { get; set; }
        public DbSet<Question>? Questions { get; set; }
    }
}

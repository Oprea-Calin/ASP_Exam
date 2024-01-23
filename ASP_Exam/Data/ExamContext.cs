using ASP_Exam.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP_Exam.Data
{
    public class ExamContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public ExamContext(DbContextOptions<ExamContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }
    }
}

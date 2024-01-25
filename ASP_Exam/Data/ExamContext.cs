using ASP_Exam.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP_Exam.Data
{
    public class ExamContext : DbContext
    {
        public DbSet<Profesori> Profesori { get; set; }
        public DbSet<Materii> Materii { get; set; }

        public ExamContext(DbContextOptions<ExamContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }
    }
}

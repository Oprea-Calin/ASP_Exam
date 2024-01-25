using ASP_Exam.Data;
using ASP_Exam.Data.Models;
using ASP_Exam.Repositories.GenericRepo;

namespace ASP_Exam.Repositories.ProfesoriRepo
{
    public class ProfesoriRepository : GenericRepository<Profesori>, IProfesoriRepository
    {
        public ProfesoriRepository(ExamContext examContext) : base(examContext)
        {
        }

     
        public Profesori FindByUsername(string username)
        {
            return _table.FirstOrDefault(u => u.Username.Equals(username));
        }

        public async Task<Profesori> FindByUsernameAsync(string username)
        {
            return _table.FirstOrDefault(u => u.Username.Equals(username));
        }

        public async Task UpdateAsync(Profesori profesori)
        {
            _examContext.Update(profesori);
            await _examContext.SaveChangesAsync();
        }
       
        
      
    }
}

using ASP_Exam.Data;
using ASP_Exam.Data.Models;
using ASP_Exam.Repositories.GenericRepo;
using Microsoft.EntityFrameworkCore;

namespace ASP_Exam.Repositories.MateriiRepo
{
    public class MateriiRepository : GenericRepository<Materii>, IMateriiRepository
    {
        public MateriiRepository(ExamContext examContext) : base(examContext)
        {

        }

        public async Task<List<Materii>> GetMateriiAsync()
        {
            return await _examContext.Materii.ToListAsync();
        }

    }
}

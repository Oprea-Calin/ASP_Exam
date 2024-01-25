using ASP_Exam.Data.Models;
using ASP_Exam.Repositories.GenericRepo;

namespace ASP_Exam.Repositories.MateriiRepo
{
    public interface IMateriiRepository : IGenericRepository<Materii>
    {
        Task<List<Materii>> GetMateriiAsync();

    }
}

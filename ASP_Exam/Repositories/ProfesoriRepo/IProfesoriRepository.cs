using ASP_Exam.Data;
using ASP_Exam.Data.Models;
using ASP_Exam.Repositories.GenericRepo;
using Microsoft.EntityFrameworkCore;

namespace ASP_Exam.Repositories.ProfesoriRepo
{
    public interface IProfesoriRepository : IGenericRepository<Profesori>
    {

        Task<Profesori> FindByUsernameAsync(string username);
        Profesori FindByUsername(string username);
        Task UpdateAsync(Profesori profesori);





    }
}

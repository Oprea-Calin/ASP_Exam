using ASP_Exam.Data.DTOs;
using ASP_Exam.Data.Models;

namespace ASP_Exam.Services
{
    public interface IMateriiService
    {
        Task<List<Materii>> GetAllAsync();
        Task<bool> Register(MateriiRegisterDTO materiiRegisterDTO);


    }
}

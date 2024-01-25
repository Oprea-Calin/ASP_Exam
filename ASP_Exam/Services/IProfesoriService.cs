using ASP_Exam.Data.DTOs;
using ASP_Exam.Data.Enums;
using ASP_Exam.Data.Models;

namespace ASP_Exam.Services
{
    public interface IProfesoriService
    {

        Task<List<Profesori>> GetAllAsync();
        Task<Profesori> GetByName(string name);
        Task<bool> Register(ProfesorRegisterDTO profesoriRegisterDto, string profesorRole);


    }
}

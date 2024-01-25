using ASP_Exam.Data.DTOs;
using ASP_Exam.Data.Enums;
using ASP_Exam.Data.Models;
using ASP_Exam.Repositories.ProfesoriRepo;
using AutoMapper;

namespace ASP_Exam.Services
{
    public class ProfesoriService : IProfesoriService
    {

        public IProfesoriRepository _profesoriRepository;
        public IMapper _mapper;

        public ProfesoriService(IProfesoriRepository profesoriRepository, IMapper mapper)
        {
            _profesoriRepository = profesoriRepository;
            _mapper = mapper;
        }

       
        public Task<Profesori> GetByName(string name)
        {
            return _profesoriRepository.FindByUsernameAsync(name);
        }
        public async Task<List<Profesori>> GetAllAsync()
        {
            var profesori = await _profesoriRepository.GetAllAsync();
            if (profesori == null) throw new Exception("No profesori found.");
            List<Profesori> result = _mapper.Map<List<Profesori>>(profesori);

            return result;

        }
     

        public async Task<bool> Register(ProfesorRegisterDTO profesoriRegisterDto, string profesorRole)
        {
            var profesorToCreate = new Profesori
            {
                Username = profesoriRegisterDto.UserName,
                Age = profesoriRegisterDto.Age,
                role = profesorRole,
            };
            

            _profesoriRepository.Create(profesorToCreate);
           return await _profesoriRepository.SaveAsync();
        }
        public async Task AssignMAteriiToProfesor(string username, Materii[] materii)
        {
            var profesor = _profesoriRepository.FindByUsername(username);
            if (profesor != null)
            {
                for (int i = 0;i<=materii.Length;i++)
                {
                    profesor.MateriiAsociate[i] = materii[i];
                }

                await _profesoriRepository.UpdateAsync(profesor);
            }
            else
            {
                throw new Exception("Profesorul nu a fost găsit.");
            }
        }

        

        
    }
}

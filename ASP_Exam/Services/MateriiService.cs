using ASP_Exam.Data.DTOs;
using ASP_Exam.Data.Models;
using ASP_Exam.Repositories.MateriiRepo;
using ASP_Exam.Repositories.ProfesoriRepo;
using AutoMapper;

namespace ASP_Exam.Services
{
    public class MateriiService : IMateriiService
    {
        public IMateriiRepository _materiiRepository;
        public IMapper _mapper;

        public MateriiService(IMateriiRepository materiiRepository, IMapper mapper)
        {
            _materiiRepository = materiiRepository;
            _mapper = mapper;
        }

        public async Task<List<Materii>> GetAllAsync()
        {
            var materii = await _materiiRepository.GetMateriiAsync();
            if (materii == null) throw new Exception("No materii found.");
            List<Materii> result = _mapper.Map<List<Materii>>(materii);

            return materii;

        }

        public async Task<bool> Register(MateriiRegisterDTO materiiRegisterDTO)
        {
            var materieToCreate = new Materii
            {
                Name = materiiRegisterDTO.Name,
                Description = materiiRegisterDTO.Description
            };


            _materiiRepository.Create(materieToCreate);
            return await _materiiRepository.SaveAsync();
        }
    }
}

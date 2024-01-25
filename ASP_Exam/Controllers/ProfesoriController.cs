using ASP_Exam.Data.DTOs;
using ASP_Exam.Data.Enums;
using ASP_Exam.Data.Models;
using ASP_Exam.Helpers.JwtUtil;
using ASP_Exam.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Exam.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProfesoriController :ControllerBase
    {
        private readonly IProfesoriService _profesoriService;

        public ProfesoriController(IProfesoriService profesoriService)
        {
            _profesoriService = profesoriService;
        }

        [AllowAnonymous]
        [HttpGet("showData")]
        public async Task<List<Profesori>> GetAllProfesori()
        {
            return (await _profesoriService.GetAllAsync());
        }

        [AllowAnonymous]
        [HttpGet("get-profesor-by-name")]
        public async Task<Profesori> GetUserByName(string name)
        {
            return (await _profesoriService.GetByName(name));
        }



        [AllowAnonymous]
        [HttpPost("create-profesor")]
        public async Task<IActionResult> CreateProfesor(ProfesorRegisterDTO profesorRegisterDto, string role)
        {
            var response = await _profesoriService.Register(profesorRegisterDto, role);

            if (response == false)
            {
                return BadRequest();
            }

            return Ok(response);
        }

        [AllowAnonymous]
        [HttpPost("Assign-materie-to-profesor")]
        public async Task<IActionResult> AssignMaterii(string nume, Materii materie)
        {
            var response = await _profesoriService.AssignMaterieToProfesor(nume,materie);
            if (response == false)
            {
                return BadRequest();
            }

            return Ok(response);
        }
    
    }
}

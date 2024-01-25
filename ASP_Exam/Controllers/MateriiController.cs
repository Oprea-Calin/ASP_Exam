using ASP_Exam.Data.DTOs;
using ASP_Exam.Data.Models;
using ASP_Exam.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Contracts;

namespace ASP_Exam.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MateriiController: ControllerBase
    {

        private readonly IMateriiService _materiiService;

        public MateriiController(IMateriiService materiiService)
        {
            _materiiService = materiiService;
        }

        [AllowAnonymous]
        [HttpGet("showMaterii")]
        public async Task<List<Materii>> GetAllMaterii()
        {
            return (await _materiiService.GetAllAsync());
        }

        [AllowAnonymous]
        [HttpPost("create-materie")]
        public async Task<IActionResult> CreateMaterie(MateriiRegisterDTO materiiRegisterDto)
        {
            var response = await _materiiService.Register(materiiRegisterDto);

            if (response == false)
            {
                return BadRequest();
            }

            return Ok(response);
        }
    }
}

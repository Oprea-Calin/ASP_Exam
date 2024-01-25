using ASP_Exam.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace ASP_Exam.Data.DTOs
{
    public class ProfesorRegisterDTO
    {
        [Required]
        public string UserName { get; set; }
        public int Age { get; set; }

        [Required]
        public Role role { get; set; }


    }
}

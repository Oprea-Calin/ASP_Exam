using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ASP_Exam.Data.Enums;
using ASP_Exam.Data.Models;
using ASP_Exam.Data.Models.BaseEntity;

namespace ASP_Exam.Data.Models
{
    public class Profesori : BaseEntityy
    {

        public string Username {  get; set; } 

        public int Age { get; set; }

        public Materii[] MateriiAsociate { get; set; }

        public string role { get; set; }
    }
}

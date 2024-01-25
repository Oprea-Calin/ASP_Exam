using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ASP_Exam.Data.Models.BaseEntity;

namespace ASP_Exam.Data.Models
{
    public class Materii : BaseEntityy
    {

        public string Name { get; set; }
        public string Description { get; set; } 
    }
}

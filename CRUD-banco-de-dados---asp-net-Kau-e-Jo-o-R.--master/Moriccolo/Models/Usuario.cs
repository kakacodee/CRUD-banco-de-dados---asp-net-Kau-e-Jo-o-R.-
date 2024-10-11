using System.ComponentModel.DataAnnotations;

namespace Moriccolo.Models
{
    public class Usuario
    {
        [Display(Name = "Código")]
        public int? IdUsu { get; set; }

        [Display(Name = "Nome Completo")]
        [Required(ErrorMessage = "O campo Nome é obrigatóriamente")]
        public string nomeUsu { get; set; }

        [Display(Name = "Cargo")]
        [Required(ErrorMessage = "O campo Cargo é obrigatóriamente")]
        public string Cargo { get; set; }

        [Display(Name = "Nascimento")]
        [Required(ErrorMessage = "O campo Nascimento é obrigatóriamente")]
        [DataType(DataType.DateTime)]
        public DateTime DataNasc { get; set; }
    }
}

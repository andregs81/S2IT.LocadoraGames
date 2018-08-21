using System;
using System.ComponentModel.DataAnnotations;

namespace S2IT.LocadoraGames.Application.ViewModels
{
    public class JogoViewModel
    {

        [Key]
        [Display(Name = "Código")]
        public int JogoId { get; set; }

        [Required(ErrorMessage = "O Título é requerido")]
        [MinLength(3, ErrorMessage = "O tamanho minimo do Nome é {1}")]
        [MaxLength(100, ErrorMessage = "O tamanho máximo do Nome é {1}")]
        public string Titulo { get; set; }

        [Display(Name = "Data do Emprestimo")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DataEmprestimo { get; set; }

        [Display(Name = "Devolver em")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DataDevolucao { get; set; }

        public int? AmigoId { get; set; }
        public virtual AmigoViewModel Amigo { get; set; }

        public bool Disponivel()
        {
            return AmigoId == null;
        }

        public string DadosdoLocatario()
        {
            return !Disponivel() ? string.Format("{0} {1} ({2})", Amigo.Nome, Amigo.Sobrenome, Amigo.Apelido) : string.Empty;
        }
    }
}

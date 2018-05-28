using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace S2IT.LocadoraGames.Application.ViewModels
{
    public class AmigoViewModel
    {

        [Key]
        [Display(Name ="Código")]
        public int AmigoId { get; set; }

        [Required(ErrorMessage = "O Nome é requerido")]
        [MinLength(3, ErrorMessage = "O tamanho minimo do Nome é {1}")]
        [MaxLength(50, ErrorMessage = "O tamanho máximo do Nome é {1}")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Sobrenome é requerido")]
        [MinLength(3, ErrorMessage = "O tamanho minimo do Nome é {1}")]
        [MaxLength(150, ErrorMessage = "O tamanho máximo do Nome é {1}")]
        public string Sobrenome { get; set; }

        public string Apelido { get; set; }

        [Required(ErrorMessage = "O Celular é requerido")]
        public string Celular { get; set; }

        public virtual ICollection<JogoViewModel> Jogos { get; set; }


    }
}

using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace S2IT.LocadoraGames.Application.ViewModels
{
    public class AmigoEnderecoViewModel
    {
        [Key]
        [Display(Name = "Código")]
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

        private string _celular;
        [Required(ErrorMessage = "O Celular é requerido")]
        public string Celular
        {
            get { return _celular; }
            set { _celular = Regex.Replace(value, @"[^\d]", ""); }
        }

        //Endereco
        [Key]
        public int EnderecoId { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public int CidadeId { get; set; }

        public virtual JogoViewModel Jogos { get; set; }
        public virtual EnderecoViewModel Endereco { get; set; }
        public virtual CidadeViewModel Cidade { get; set; }
        public virtual AmigoViewModel Amigo { get; set; }

    }
}
